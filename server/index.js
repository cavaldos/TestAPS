const express = require('express');
const app = express();
const port = 3000;

const indexRouter = require('./routes/index');

// Sử dụng routes
app.use('/', indexRouter);
// Lắng nghe kết nối tại cổng 3000
app.listen(port, () => {
  console.log(`Example app listening at http://localhost:${port}`);
});
