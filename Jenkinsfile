pipeline {
    agent any
    environment {
        DOTNET_CLI_HOME="C:\\Program Files\\dotnet"
        SOLUTION = 'CoreWebApisWithDockerFile.sln'
        DB_CONTEXT = 'CIITstudContext'
        // Use Jenkins credentials for sensitive connection strings
        DB_CONNECTION = credentials('Server=115.124.106.98;Database=ciitstud_;User Id=ciituser;Password=CIIT#0908;TrustServerCertificate=True')
    }
    stages {
        stage("Checkout") {
         steps {
               checkout scm
         }
        }
         stage('Restore') {
            steps {
                // Restore NuGet packages [10]
                bat "dotnet restore ${env.SOLUTION}"
            }
        }
        stage('Build') {
            steps {
                // Build the project in Release mode [10]
                bat "dotnet build ${env.SOLUTION} --configuration Release --no-restore"
            }
        }
         stage('Database Migration') {
            steps {
                // Apply pending EF Core migrations to the SQL Server database [12]
                // Requires the dotnet-ef tool installed on the build agent
                bat "dotnet ef database update --context ${env.DB_CONTEXT} --connection \"${env.DB_CONNECTION}\""
            }
        }
         stage('Test') {
            steps {
                // Run unit and integration tests [4, 5]
                bat "dotnet test ${env.SOLUTION} --configuration Release --no-build"
            }
        }

        stage('Publish') {
            steps {
                // Package the API for deployment [10]
                bat "dotnet publish ${env.SOLUTION} -c Release -o ./publish"
            }
        }

    }
    post {
        success {
            echo "Build, TEst and Publish stages completed successfully."
        }
    }

}
