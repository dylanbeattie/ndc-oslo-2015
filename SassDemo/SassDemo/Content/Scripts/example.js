var TypeScriptGreeter = (function () {
    function TypeScriptGreeter(greeting) {
        this.greeting = greeting;
    }
    TypeScriptGreeter.prototype.greet = function (name) {
        return this.greeting + ", " + name + " (from TypeScript)";
    };
    return TypeScriptGreeter;
})();
;
//# sourceMappingURL=example.js.map
