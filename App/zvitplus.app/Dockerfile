# Етап 1: збірка React/Vite через Node.js
FROM node:20-alpine AS build
WORKDIR /app

ARG VITE_API_URL=http://localhost:5267/api
ENV VITE_API_URL=${VITE_API_URL}

COPY package*.json ./
RUN npm ci

COPY . .
RUN npm run build

# Етап 2: віддача готових статичних файлів через NGINX
FROM nginx:alpine
COPY nginx.conf /etc/nginx/conf.d/default.conf
COPY --from=build /app/dist /usr/share/nginx/html

EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]
