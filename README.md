# Laboratorio 02
Ejercicio Docker Compose

## Stack

### API
- Minimal API
- El MESSAGE contiene mi nombre como Variable de Entorno
- Docker
- 3 copias de una API build local

### BD


# Indicaciones

## Comandos
```bash
docker compose up -d
```
API 1: http://localhost:3000
API 2: http://localhost:3001
API 3: http://localhost:3002

## Configuración por entorno
```
MESSAGE=Valentino Paredes
```

POSTGRES_PASSWORD=mysecretpassword

## Volumenes
vol_postgresql

## Tipos de Redes en Docker
- Bridge: Es la red predeterminada para contenedores. Permite la comunicación entre contenedores en un mismo host. Es la que utiliza normalmente Docker Compose.

- Host: El contenedor utiliza directamente la red del equipo anfitrión.

-None: El contenedor no tiene conectividad de red.

Overlay

Permite conectar contenedores entre diferentes hosts Docker.

Macvlan

Permite que un contenedor tenga una identidad de red propia en la red física.

Ipvlan

Permite conectar contenedores utilizando la interfaz de red del host mediante IPvlan.

## Tipos de Volumenes en Docker

## Conventional Commits

# Creditos
- Paredes Paz, Valentino Elfre
