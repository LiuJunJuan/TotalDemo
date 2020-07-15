module.exports = {
  publicPath: './',
  filenameHashing: true,

  devServer: {
    host: 'localhost',
    port: 8081,
    //proxy: 'https://app.ktlicensing.cn'
    proxy:'http://localhost:50760'
  },

  chainWebpack: config => {
    /** 去掉console.log debugger sourceMap*/
    config.optimization.minimize(true);
  },

  pluginOptions: {
    'style-resources-loader': {
      preProcessor: 'scss',
      patterns: []
    }
  },

  lintOnSave: false
}
