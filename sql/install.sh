docker build -t my-mssql .
docker run -p 1445:1433 -d my-mssql