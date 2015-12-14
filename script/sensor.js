var osc = require("osc");

var udpPort = new osc.UDPPort({
});

udpPort.send({
    address: "/s_new",
    args: ["default", 100]
}, "127.0.0.1", 57110);

