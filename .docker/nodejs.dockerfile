FROM node:19-bullseye AS build

WORKDIR /workspace
COPY ./nodejs/package*.json .

RUN npm clean-install --only=production
