# ImageService
The service responsible for image persistence, processing and pickup.  

![basic-architecture](https://github.com/Balanda-and-Lobster/ImageService/blob/main/docs/resources/overview.png)


## oml
1. initial solution  
2. some endpoint to ping  
3. docker  
4. custom logs  
5. lib to work with GCP image/file  
6. relational db (for instance: mysql, mssql, postgressql, etc)
## bober
1. create free gcp account  
1. docker improvements  
2. investigate GCP for image/file storage  
3. setup GCP  
4. investigate the best way to work with db in k8s (cheap and reliable)  


docker build . -t imageservice
docker run -d -p 8085:80 imageservice
http://localhost:8085/WeatherForecast



## notes
PR restirction after CI/CD implementation  
probably some kind of stylecope in future  
docs  
