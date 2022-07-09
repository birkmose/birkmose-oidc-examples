FROM node:18-alpine as build-stage
WORKDIR /app
COPY package*.json /app/
RUN yarn install
COPY ./ /app/
RUN yarn build
# Stage 1, based on Nginx, to have only the compiled app, ready for production with Nginx
FROM nginx:1.23-alpine
COPY --from=build-stage /app/nginx.conf /etc/nginx/conf.d/default.conf
COPY --from=build-stage /app/build/ /usr/share/nginx/html
