FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
# Publish dosyalarını kopyalıyoruz
COPY src/SmartClinic.HttpApi.Host/bin/Release/net10.0/publish/ .
# SERTİFİKAYI BURADA KOPYALIYORUZ (Kritik nokta)
COPY src/SmartClinic.HttpApi.Host/openiddict.pfx . 

ENV ASPNETCORE_URLS=http://+:80
ENTRYPOINT ["dotnet", "SmartClinic.HttpApi.Host.dll"]