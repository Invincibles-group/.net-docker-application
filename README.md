# 🧩 TaskFlow – Containerized .NET 8 MVC Web App

**TaskFlow** is a simple task management website built with **ASP.NET Core MVC**, **SQL Server**, and **Nginx**, all running in **Docker containers**.
It demonstrates a realistic DevOps-ready architecture with multi-container orchestration, networking, and data persistence.

---

## 🚀 Features

* 🌐 ASP.NET Core 8 MVC web app
* 🗄 SQL Server 2022 (containerized)
* 🔁 Nginx reverse proxy for clean routing
* 🐳 Fully Dockerized setup using Docker Compose
* 💾 Persistent database volume
* ⚙️ Ready for CI/CD integration (GitHub Actions / Azure DevOps)

---

## 🧱 Architecture

```
+-----------------------+
|      NGINX (80)       |  ← Reverse proxy to .NET app
+-----------------------+
           |
           ▼
+-----------------------+
|   .NET 8 MVC App      |  ← TaskFlow Web (port 8080)
+-----------------------+
           |
           ▼
+-----------------------+
|   SQL Server 2022     |  ← Data storage (port 1433)
+-----------------------+
```

---

## 🗂 Folder Structure

```
TaskFlow/
├── docker-compose.yml
├── nginx/
│   ├── Dockerfile
│   └── nginx.conf
└── src/
    └── TaskFlow.Web/
        ├── Controllers/
        ├── Models/
        ├── Views/
        ├── Data/
        ├── Dockerfile
        ├── Program.cs
        ├── appsettings.json
        └── TaskFlow.Web.csproj
```

---

## ⚙️ Prerequisites

* [Docker Desktop](https://www.docker.com/products/docker-desktop/) (Windows/macOS)
* or [Docker Engine](https://docs.docker.com/engine/install/) (Linux)

Ensure Docker is running before starting the containers.

---

## 🏗 How to Build and Run

### 1️⃣ Clone the repository

```bash
git clone https://github.com/yourusername/TaskFlow.git
cd TaskFlow
```

### 2️⃣ Build and start containers

```bash
docker-compose up -d --build
```

This command will:

* Build the .NET app image
* Start SQL Server and seed sample data
* Start Nginx as a reverse proxy

---

## 🌐 Access the Application

| Service        | URL                                            | Description                                |
| -------------- | ---------------------------------------------- | ------------------------------------------ |
| Web App (.NET) | [http://localhost:8080](http://localhost:8080) | Direct access to the MVC app               |
| Nginx Proxy    | [http://localhost](http://localhost)           | (If port 80 mapped) Reverse proxy endpoint |
| Database       | `localhost,1433`                               | Use with Azure Data Studio / SSMS          |

> Default credentials:
>
> * **User:** `sa`
> * **Password:** `YourStrong!Passw0rd`

---

## 🧠 Common Commands

```bash
# List all running containers
docker ps

# View app logs
docker logs taskflow_web

# Stop all containers
docker-compose down

# Rebuild from scratch
docker-compose up -d --build --force-recreate
```

---

## 🧩 Technologies Used

| Component        | Technology              |
| ---------------- | ----------------------- |
| Backend          | ASP.NET Core 8 (MVC)    |
| Database         | SQL Server 2022         |
| Reverse Proxy    | Nginx (alpine)          |
| Containerization | Docker & Docker Compose |
| ORM              | Entity Framework Core   |
| Language         | C#                      |

---

## 🔮 Future Enhancements

* Add **GitHub Actions** for CI/CD build + Docker push
* Deploy to **Azure App Service** or **AKS** with Terraform
* Integrate **Prometheus + Grafana** for monitoring
* Add authentication and user roles

---

## 🧑‍💻 Author

**Hemant Gorantla**
DevOps Engineer | .NET | Azure | Docker | Terraform
[LinkedIn](https://linkedin.com) • [GitHub](https://github.com)

---

## 🪄 License

MIT License © 2025 Hemant Gorantla
You’re free to use, modify, and share with attribution.
