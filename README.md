# Structured Logging

- ASP.NET Core
- Serilog
- Elastic Search

---

## Docker

**Network**

```sh
docker network create elastic
```

**ElasticSearch**

```sh
docker run -d --name elasticsearch --net elastic -p 9200:9200 -p 9300:9300 -e "discovery.type=single-node" elasticsearch:7.10.1
```

**Kibana**

```sh
docker run -d --name kibana --net elastic -p 5601:5601 kibana:7.10.1
```

---

## docker-compose

**TODO**

---
