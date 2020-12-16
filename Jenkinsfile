pipeline {
    agent {
        docker {
            image 'mcr.microsoft.com/dotnet/core/sdk:3.1.101'
        }
    }

   stages {
      stage('Verify Branch') {
         steps {
            echo "Branch is $GIT_BRANCH"
            echo "Workspace is $WORKSPACE"
         }
      }
      stage('Verify Environment') {
         steps {
            sh '''
            dotnet --list-sdks
            dotnet --list-runtimes
            '''
            sh 'printenv'
            sh 'ls -l "$WORKSPACE"'
         }
      }
      stage('Build') {
         steps {
            dir("$WORKSPACE") {
               sh 'dotnet build "sandbox/src/webapi/Sandbox.WebApi.csproj"'
            }
         }
      }
      stage('Unit Test') {
         steps {
            dir("$WORKSPACE") {
               sh 'dotnet test sandbox/src/tests/Sandbox.Tests.csproj'
            }
         }
      }
      // stage('Smoke Test') {
      //    steps {
      //       sh 'dotnet "$WORKSPACE/m4/src/Pi.Web/bin/Debug/netcoreapp3.1/Pi.Web.dll"'
      //    }
      // }




      // stage('Docker Build') {
      //    steps {
      //       sh 'dotnet build "$WORKSPACE/m4/src/Pi.Web/Pi.Web.csproj"'
      //    }
      // }
      // stage('Start test app') {
      //    steps {
      //       //sh "docker-compose up -d" // this doesn't work, but would be better than solution
      //       sh "docker run -dt -p 8080:80 --name myapp sandbox_aspnetapp"
      //    }
      //    post {
      //       success {
      //          echo "App started successfully :)"
      //       }
      //       failure {
      //          echo "App failed to start :("
      //       }
      //    }
      // }
      // stage('Test API Rest') {
      //    steps {
      //       sh 'newman run "./tests/Newman/Sandbox API Test Collection.postman_collection.json" -e "./tests/Newman/Sandbox API Test Environment - Dev.postman_environment.json" -r junit,html --reporter-junit-export var/reports/newman/junit/newman.xml --reporter-html-export var/reports/newman/html/index.html'

      //       publishHTML([allowMissing: false, alwaysLinkToLastBuild: false, keepAll: false, reportDir: 'var/reports/newman/html', reportFiles: 'index.html', reportName: 'Newman API Test', reportTitles: ''])
      //    }
      // }      
      // stage('Stop test app') {
      //    steps {
      //       // echo "docker-compose down" // this doesn't work, but would be better than solution
      //       sh "docker stop myapp"
      //       sh "docker rm myapp"
      //    }
      // }
   }
}
