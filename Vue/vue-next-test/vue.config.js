module.exports = {
  lintOnSave: false,
  devServer: {
    public: 'localhost',
    port: 8080,
    proxy: 'https://app.ktlicensing.cn'
    //proxy:'http://localhost:50760'
  },
}
