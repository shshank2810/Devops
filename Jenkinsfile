pipeline {
    agent any
    stages {
        stage('Checkout') {
            steps {
                // Checkout your code from your Git repository
                git 'https://github.com/shshank2810/Devops.git'
            }
        }
        stage('Restore Packages') {
            steps {
                // Restore NuGet packages
                sh 'dotnet restore'
            }
        }
        stage('Build') {
            steps {
                // Build the .NET project using MSBuild
                sh 'dotnet build'
            }
        }
        stage('Test') {
            steps {
                // Run tests (replace 'your_test_command' with your actual test command)
                sh 'dotnet test'
            }
        }
    }
}
