"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var foo_1 = require("./foo");
var bar = foo_1.foo;
var Utility;
(function (Utility) {
    function log(msg) {
        if (typeof msg === 'string')
            console.log(msg);
    }
    Utility.log = log;
    function error(msg) {
        console.log(msg);
    }
    Utility.error = error;
})(Utility || (Utility = {}));
Utility.error('eee');
var name;
name = {
    first: null,
    second: undefined
};
var numArr = [1, 2];
var reversedNums = numArr.reverse();
//window.helloWorld = () => console.log("Test");
//# sourceMappingURL=bar.js.map