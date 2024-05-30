# Sử dụng image chính thức của Node.js
FROM node:14

# Thiết lập thư mục làm việc trong container
WORKDIR /usr/src/app

# Sao chép package.json và package-lock.json (nếu có)
COPY package*.json ./

# Cài đặt các phụ thuộc
RUN npm install

# Sao chép toàn bộ mã nguồn vào container
COPY . .

# Expose cổng mà ứng dụng của bạn sẽ chạy
EXPOSE 3000

# Lệnh để chạy ứng dụng npm start
CMD [ "npm", "start" ]
