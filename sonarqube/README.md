# SonarQube

##  Prerequisites

- Docker. See [Dowload and install docker](https://docs.docker.com/desktop/#download-and-install)
- Increase max virtual memory for docker
  - Windows
    - Open powershell, run
    - > wsl -d docker-desktop
    - Then
    - > sysctl -w vm.max_map_count=262144
  - Linux
    - Open terminal, run
    - > sysctl -w vm.max_map_count=262144
- Install Java : [Java 18](https://www.oracle.com/java/technologies/downloads/#java18)

## Install Sonar in docker

- Open shell in CESI-EasySave/sonarqube, run
- > docker-compose up -d

## Start using Sonar

- Browse http://localhost:35454
- Use default credential : admin/admin
- Change the password
- Create a manually project
- Select "Locally" to analyse the repository
- Generate a token
- Follow instructions to install .NET sonar tool