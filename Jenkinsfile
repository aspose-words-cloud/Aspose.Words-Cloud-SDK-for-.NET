properties([
	gitLabConnection('gitlab'),
	[$class: 'ParametersDefinitionProperty', 
		parameterDefinitions: [
			[$class: 'StringParameterDefinition', name: 'branch', defaultValue: 'master', description: 'the branch to build'],
			[$class: 'StringParameterDefinition', name: 'apiUrl', defaultValue: 'https://api-qa.aspose.cloud', description: 'api url'],
            [$class: 'BooleanParameterDefinition', name: 'ignoreCiSkip', defaultValue: false, description: 'ignore CI Skip'],
            [$class: 'StringParameterDefinition', name: 'credentialsId', defaultValue: '6839cbe8-39fa-40c0-86ce-90706f0bae5d', description: 'credentials id'],
            [$class: 'BooleanParameterDefinition', name: 'packageTesting', defaultValue: false, description: 'Testing package from repository without local sources. Used for prodhealthcheck'],
		]
	]

])

def needToBuild = false
def packageTesting = false

node('words-linux') {
	try {
			stage('checkout'){
				checkout([$class: 'GitSCM', branches: [[name: params.branch]], doGenerateSubmoduleConfigurations: false, extensions: [[$class: 'LocalBranch', localBranch: "**"]], submoduleCfg: [], userRemoteConfigs: [[credentialsId: '361885ba-9425-4230-950e-0af201d90547', url: 'https://git.auckland.dynabic.com/words-cloud/words-cloud-dotnet.git']]])
				
                sh 'git show -s HEAD > gitMessage'
                def commitMessage = readFile('gitMessage').trim()
                echo commitMessage
                needToBuild = params.ignoreCiSkip || !commitMessage.contains('[ci skip]')
                packageTesting = params.packageTesting
                sh 'git clean -fdx'
			}
        
        if (packageTesting || needToBuild) {
            docker.image('mcr.microsoft.com/dotnet/sdk:9.0').inside('-e HOME=/tmp -e DOTNET_CLI_HOME=/tmp') {
                stage('build') {
                    sh 'mkdir -p Settings testResults'
                    withCredentials([usernamePassword(credentialsId: params.credentialsId, passwordVariable: 'ClientSecret', usernameVariable: 'ClientId')]) {
                        writeFile file: 'Settings/servercreds.json', text: groovy.json.JsonOutput.toJson([ClientId: env.ClientId, ClientSecret: env.ClientSecret, BaseUrl: params.apiUrl])
                    }
                    if (packageTesting) {
                        sh '''for project in Aspose.Words.Cloud.Sdk.Tests/Aspose.Words.Cloud.Sdk.Tests.csproj Aspose.Words.Cloud.Sdk.BddTests/Aspose.Words.Cloud.Sdk.BddTests.csproj; do
                            if [ "$(grep -c '<ProjectReference' "$project")" -ne 1 ] || ! grep -Fqx '    <ProjectReference Include="..\\Aspose.Words.Cloud.Sdk\\Aspose.Words.Cloud.Sdk.csproj" />' "$project"; then
                                echo "Unexpected SDK reference in $project" >&2
                                exit 1
                            fi
                            sed -i 's#^    <ProjectReference.*#    <PackageReference Include="Aspose.Words-Cloud" Version="*" />#' "$project"
                            dotnet restore "$project" -p:TargetFramework=net9.0 --force-evaluate
                            dotnet build "$project" --framework net9.0 --no-restore
                        done'''
                    } else {
                        sh 'dotnet restore Aspose.Words.Cloud.Sdk.sln'
                        sh 'dotnet build Aspose.Words.Cloud.Sdk.sln --no-restore'
                    }
                }

                stage('core tests') {
                    try {
                        sh 'dotnet test Aspose.Words.Cloud.Sdk.Tests/Aspose.Words.Cloud.Sdk.Tests.csproj --framework net9.0 --logger "junit;LogFilePath=$WORKSPACE/testResults/Tests-results-net9.0.xml" --logger "console;verbosity=normal" --no-build --no-restore'
                    } finally {
                        junit 'testResults/Tests-results-net9.0.xml'
                    }
                }

                stage('bdd core tests') {
                    try {
                        sh 'dotnet test Aspose.Words.Cloud.Sdk.BddTests/Aspose.Words.Cloud.Sdk.BddTests.csproj --framework net9.0 --logger "junit;LogFilePath=$WORKSPACE/testResults/BddTests-results-net9.0.xml" --logger "console;verbosity=normal" --no-build --no-restore'
                    } finally {
                        junit 'testResults/BddTests-results-net9.0.xml'
                    }
                }
            }
        }
	} finally {
		cleanWs()
	}
}