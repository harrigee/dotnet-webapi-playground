#!/bin/bash
set -euo pipefail

docker build --rm -t productive-dev/cloud-customers:latest .
docker run --rm -p 5001:5001 -p 5002:5002 -e ASPNETCORE_HTTP_PORT=https://+:5002 -e ASPNETCORE_URLS=http://+:5001 productive-dev/cloud-customers