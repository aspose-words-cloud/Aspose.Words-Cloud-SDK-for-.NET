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

def buildCacheImage = "git.auckland.dynabic.com:4567/words-cloud/api/net" 
def needToBuild = false

node('win2019_1') {
	try {
			stage('checkout'){
				checkout([$class: 'GitSCM', branches: [[name: params.branch]], doGenerateSubmoduleConfigurations: false, extensions: [[$class: 'LocalBranch', localBranch: "**"]], submoduleCfg: [], userRemoteConfigs: [[credentialsId: '361885ba-9425-4230-950e-0af201d90547', url: 'https://git.auckland.dynabic.com/words-cloud/words-cloud-dotnet.git']]])
				
                bat 'git show -s HEAD > gitMessage'
                def commitMessage = readFile('gitMessage').trim()
                echo commitMessage
                needToBuild = params.ignoreCiSkip || !commitMessage.contains('[ci skip]')               
                bat 'git clean -fdx'
			}
        
        if (needToBuild) {
                stage('build') {
                    withCredentials([usernamePassword(credentialsId: 'cc2e3c9b-b3da-4455-b702-227bcce18895', usernameVariable: 'dockerrigistry_login', passwordVariable: 'dockerregistry_password')]) {
					bat 'docker login -u "%dockerrigistry_login%" -p "%dockerregistry_password%" git.auckland.dynabic.com:4567'
				}
                    bat 'if exist testResults del testResults'
                    bat 'mkdir testResults'
                    bat 'if exist Settings del Settings'
                    bat 'mkdir Settings'
                    def apiUrl = params.apiUrl
                    withCredentials([usernamePassword(credentialsId: params.credentialsId, passwordVariable: 'ClientSecret', usernameVariable: 'ClientId')]) {
                        bat "echo {\"ClientId\":\"%ClientId%\",\"ClientSecret\":\"%ClientSecret%\", \"BaseUrl\":\"%apiUrl%\" } > Settings\\servercreds.json"
                    }
                    
                    bat (script: "docker pull ${buildCacheImage}/buildenv || exit 0")
                    bat 'if exist c:\\temp\\netbuild del /s /q c:\\temp\\netbuild'
                    bat 'if exist temp del /s /q temp'
                    powershell(script: 'Copy-Item -Path . -Destination c:\\temp\\netbuild -filter *.csproj -Recurse -Container')
                    powershell(script: 'Copy-Item -Path . -Destination c:\\temp\\netbuild -filter *.sln -Recurse -Container')
                    powershell(script: '$currFolderName = (Get-Item .).Name ; Copy-Item -Path c:\\temp\\netbuild\\$currFolderName -Destination .\\temp -Recurse -Container')
                    bat (script: "docker build --force-rm -m 4g -f scripts\\buildEnv.Dockerfile --isolation=hyperv --cache-from=${buildCacheImage}/buildenv -t ${buildCacheImage}/buildenv temp")
                    bat (script: "docker push ${buildCacheImage}/buildenv")

                    bat (script: "docker pull ${buildCacheImage} || exit 0")
                    bat (script: "docker build --force-rm -m 4g -f scripts\\build.Dockerfile --isolation=hyperv -t netsdkbuild --cache-from=${buildCacheImage} -t ${buildCacheImage} .")
                    bat (script: "docker push ${buildCacheImage}")
                }
           
        
                stage('net tests') {	
                    try {
                        bat 'docker run --rm -v %CD%\\testResults:C:\\build\\testResults\\ --isolation=hyperv netsdkbuild c:\\build\\scripts\\test.bat Tests net462'
                    } finally {
                        junit '**\\testResults\\Tests-results-net462.xml'
                    }
                }

                stage('core tests') {
                    try {
                        bat 'docker run --rm -v %CD%\\testResults:C:\\build\\testResults --isolation=hyperv netsdkbuild c:\\build\\scripts\\test.bat Tests netcoreapp3.1'
                    } finally {
                        junit '**\\testResults\\Tests-results-netcoreapp3.1.xml'
                    }
                }

                stage('bdd net tests') {
                    try {
                        bat 'docker run --rm -v %CD%\\testResults:C:\\Build\\testResults --isolation=hyperv netsdkbuild c:\\build\\scripts\\test.bat BddTests net462'
                    } finally {
                        junit '**\\testResults\\BddTests-results-net462.xml'
                    }
                }

                stage('bdd core tests') {
                    try {
                        bat 'docker run --rm -v %CD%\\testResults:C:\\Build\\testResults --isolation=hyperv netsdkbuild c:\\build\\scripts\\test.bat BddTests netcoreapp3.1'
                    } finally {
                        junit '**\\testResults\\BddTests-results-netcoreapp3.1.xml'
                    }
                }
        }
	} finally {
        bat (script: 'docker rmi $(docker images -f "dangling=true" -q) || exit 0')
		cleanWs()
	}
}