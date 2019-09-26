module.exports = {
  devServer: {
    proxy: {
      '/api': {
        target: 'http://localhost:53954',
        pathRewrite: {'^/api' : ''}
      }
    }
  }
}