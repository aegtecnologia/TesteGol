const proxy = [
  {
    context: '/api',
    target: 'http://localhost:53954',
    pathRewrite: {'^/api' : ''}
  }
];
module.exports = proxy;