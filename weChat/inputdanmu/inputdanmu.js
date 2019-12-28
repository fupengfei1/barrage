Page({
  data: {
    send: [],
    receive: [],
  },

  onLoad: function (options) {

    var that = this;
    console.log(this);
    var receivetemp = this.data.receive;
    //建立连接
    wx.connectSocket({
      url: "wss://www.colossusjinxin.com:11688/lcj控制台",
    })

    //连接成功
    wx.onSocketOpen(function () {
      console.log("微信客户端已连接成功！！");
      /* wx.sendSocketMessage({
        data: 'stock',
      }) */
    })

    //接收数据
    /* wx.onSocketMessage(function (data) {
      console.log(data);
      console.log("客户端回复的消息" + data.data);
      receivetemp.push(data.data);
      that.setData({
        receive: receivetemp
      })
    }) */

    //连接失败
    wx.onSocketError(function () {
      console.log('websocket连接失败！');
    })
  },
  sendMessage: function (e) {
    console.log(e);
    var sendtemp = this.data.send;
    sendtemp.push(' 发送的消息：' + e.detail.value.message);
    /* this.setData({
      send: sendtemp
    }) */
    console.info(this.data.receive);
    wx.sendSocketMessage({
      data: e.detail.value.message
    })
  }
})