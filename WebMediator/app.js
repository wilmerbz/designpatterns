var Colleague = function (id) {
    var that = this;
    that.colleagueId = id;
};

Colleague.prototype.receiveMessage = function (senderId, message) {
    var that = this;
    console.log('Message received by ' + that.colleagueId + ': Sender: ' + senderId + ' | Message: ' + message);
}

var MainMediator = function () {

    var that = this;

    that._colleagues = {};

};


MainMediator.prototype.register = function (colleague) {
    var that = this;
    var targetColleagueId = colleague.colleagueId;
    that._colleagues[targetColleagueId] = colleague;

    console.log('Colleague: ' + targetColleagueId + ' registered successfully');
}


MainMediator.prototype.sendMessage = function (message, senderColleagueId, toColleagueId) {
    var that = this;

    if (!message || !senderColleagueId) return;

    if (toColleagueId) {
        that._sendMessageToColleague(senderColleagueId, toColleagueId, message);
    } else {
        for (var targetColleagueId in that._colleagues) {
            if (that._colleagues.hasOwnProperty(targetColleagueId)) {

                if (targetColleagueId === senderColleagueId) continue;

                that._sendMessageToColleague(senderColleagueId, targetColleagueId, message);
            }
        }
    }
}

MainMediator.prototype._sendMessageToColleague = function (senderColleagueId, targetColleagueId, message) {
    var that = this;
    var colleague = that._colleagues[targetColleagueId];

    if (!colleague) return;

    setTimeout(function () {
        colleague.receiveMessage(senderColleagueId, message);
    }, 0);
}


var mainMediator = new MainMediator();

for (var i = 1; i <= 10; i++) {
    var colleague = new Colleague('Colleague' + i);
    mainMediator.register(colleague);
}


mainMediator.sendMessage('Message 1', 'Application')
console.log(' - - - - - - - - -');
mainMediator.sendMessage('Message 2', 'Colleague3');
console.log(' - - - - - - - - -');
mainMediator.sendMessage('Message 3', 'Colleague3', 'Colleague10');

mainMediator.sendMessage('Message 4', 'Colleague3', 'Colleague11');
