pipeline {
  agent any
  stages {
    stage('Hello') {
      steps {
        sh 'echo "hello, this is $BUILD_NUMBER on demo $DEMO"'
      }
    }

  }
  environment {
    DEMO = '1'
  }
}