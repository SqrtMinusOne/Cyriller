FROM ubuntu:18.04
RUN apt-get update
RUN apt-get install -y wget
RUN wget https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
RUN dpkg -i packages-microsoft-prod.deb
RUN apt-get update
RUN apt-get install -y dotnet-sdk-3.1 aspnetcore-runtime-3.1
COPY . ./cyriller
WORKDIR ./cyriller
RUN (cd Cyriller.Zipper && dotnet build)
RUN (cd Cyriller.Repl && dotnet build)
CMD (cd Cyriller.Repl && dotnet run)
