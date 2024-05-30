# Sử dụng image chính thức của Microsoft SQL Server làm image cơ bản
FROM mcr.microsoft.com/mssql/server:2022-latest

# Thiết lập biến môi trường
ENV SA_PASSWORD=YourStrong!Passw0rd
ENV ACCEPT_EULA=Y

# Expose cổng 1433
EXPOSE 1433

# Lệnh để khởi động SQL Server
CMD /opt/mssql/bin/sqlservr
