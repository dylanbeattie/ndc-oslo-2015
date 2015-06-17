var TypeScriptGreeter = (function () {
    function TypeScriptGreeter(name) {
        this.name = name;
    }
    TypeScriptGreeter.prototype.greet = function (name) {
        return "Hello, " + this.name + " (from TypeScript!)";
    };
    return TypeScriptGreeter;
})();
;
//# sourceMappingURL=example.js.map
