function printLabel(labelledObj) {
    console.log(labelledObj.label);
}
var myObj = { size: 10, label: "Size 10 Object" };
printLabel(myObj);
function createSquare(config) {
    var newSquare = { color: "white", area: 100 };
    if (config.color) {
        // Error: Property 'clor' does not exist on type 'SquareConfig'
        newSquare.color = config.color;
    }
    if (config.width) {
        newSquare.area = config.width * config.width;
    }
    return newSquare;
}
var mySquare = createSquare({ color: "black" });
function identity(arg) {
    return arg;
}
function identityT(arg) {
    return arg;
}
var FileAccess;
(function (FileAccess) {
    // constant members
    FileAccess[FileAccess["None"] = 0] = "None";
    FileAccess[FileAccess["Read"] = 2] = "Read";
    FileAccess[FileAccess["Write"] = 4] = "Write";
    FileAccess[FileAccess["ReadWrite"] = 6] = "ReadWrite";
    // computed member
    FileAccess[FileAccess["G"] = "123".length] = "G";
})(FileAccess || (FileAccess = {}));
function extend(first, second) {
    var result = {};
    for (var id in first) {
        result[id] = first[id];
    }
    for (var id in second) {
        if (!result.hasOwnProperty(id)) {
            result[id] = second[id];
        }
    }
    return result;
}
var Person = /** @class */ (function () {
    function Person(name) {
        this.name = name;
    }
    return Person;
}());
var ConsoleLogger = /** @class */ (function () {
    function ConsoleLogger() {
    }
    ConsoleLogger.prototype.log = function () {
        // ...
    };
    return ConsoleLogger;
}());
var jim = extend(new Person("Jim"), new ConsoleLogger());
var n = jim.name;
jim.log();
var ConsoleBird = /** @class */ (function () {
    function ConsoleBird() {
    }
    ConsoleBird.prototype.fly = function () { };
    ;
    ConsoleBird.prototype.layEggs = function () { };
    ;
    return ConsoleBird;
}());
var ConsoleFish = /** @class */ (function () {
    function ConsoleFish() {
    }
    ConsoleFish.prototype.swim = function () {
        return "test";
    };
    ;
    ConsoleFish.prototype.layEggs = function () { };
    ;
    return ConsoleFish;
}());
function getSmallPet() {
    var value = 'Test';
    return null;
}
var pet = getSmallPet();
pet.layEggs(); // okay
//pet.swim();    // errors
if (pet.swim) {
    pet.swim();
}
else {
    pet.fly();
}
//# sourceMappingURL=file.js.map