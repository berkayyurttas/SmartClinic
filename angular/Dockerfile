FROM nginx:alpine
# Eğer Dockerfile angular klasöründeyse direkt dist'ten başla
COPY dist/SmartClinic/browser /usr/share/nginx/html
EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]