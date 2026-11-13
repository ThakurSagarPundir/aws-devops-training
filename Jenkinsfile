
pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                git branch: 'main',
                    url: 'https://github.com/ThakurSagarPundir/aws-devops-training.git'
            }
        }

        stage('Restore') {
            steps {
                sh 'dotnet restore DevOpsApi/DevOpsApi.csproj'
            }
        }

        stage('Build') {
            steps {
                sh 'dotnet build DevOpsApi/DevOpsApi.csproj --configuration Release --no-restore'
            }
        }

        stage('Test') {
            steps {
                sh 'dotnet test DevOpsApi.Tests/DevOpsApi.Tests.csproj --configuration Release'
            }
        }

        stage('Publish') {
            steps {
                sh 'dotnet publish DevOpsApi/DevOpsApi.csproj --configuration Release --no-build --output publish'
            }
        }

        stage('Deploy') {
            steps {
                sh 'cp -r publish/. /opt/devopsapi/'
                sh 'sudo /usr/bin/systemctl restart devopsapi'
            }
        }
    }
}
