properties([
	gitLabConnection('gitlab'),
	[$class: 'ParametersDefinitionProperty', 
		parameterDefinitions: [
			[$class: 'StringParameterDefinition', name: 'branch', defaultValue: 'master', description: 'the branch to build'],
			[$class: 'StringParameterDefinition', name: 'apiUrl', defaultValue: 'https://api-qa.aspose.cloud', description: 'api url'],
            [$class: 'BooleanParameterDefinition', name: 'ignoreCiSkip', defaultValue: false, description: 'ignore CI Skip'],
            [$class: 'StringParameterDefinition', name: 'credentialsId', defaultValue: '6839cbe8-39fa-40c0-86ce-90706f0bae5d', description: 'credentials id'],
		]
	]

])

def needToBuild = false

node('words-linux') {
	try {
			stage('checkout'){
				checkout([$class: 'GitSCM', branches: [[name: params.branch]], doGenerateSubmoduleConfigurations: false, extensions: [[$class: 'LocalBranch', localBranch: "**"]], submoduleCfg: [], userRemoteConfigs: [[credentialsId: '361885ba-9425-4230-950e-0af201d90547', url: 'https://git.auckland.dynabic.com/words-cloud/words-cloud-dotnet.git']]])
				
                sh 'git show -s HEAD > gitMessage'
                def commitMessage = readFile('gitMessage').trim()
                echo commitMessage
                needToBuild = params.ignoreCiSkip || !commitMessage.contains('[ci skip]')               
                sh 'git clean -fdx'
			}
        
        if (needToBuild) {
            docker.image('mcr.microsoft.com/dotnet/sdk:9.0').inside('-e HOME=/tmp -e DOTNET_CLI_HOME=/tmp') {
                stage('build') {
                    sh 'mkdir -p Settings testResults'
                    withCredentials([usernamePassword(credentialsId: params.credentialsId, passwordVariable: 'ClientSecret', usernameVariable: 'ClientId')]) {
                        writeFile file: 'Settings/servercreds.json', text: groovy.json.JsonOutput.toJson([ClientId: env.ClientId, ClientSecret: env.ClientSecret, BaseUrl: params.apiUrl])
                    }
                    sh 'dotnet restore Aspose.Words.Cloud.Sdk.sln'
                    sh 'dotnet build Aspose.Words.Cloud.Sdk.sln --no-restore'
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