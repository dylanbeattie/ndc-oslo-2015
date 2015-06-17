class TypeScriptGreeter {
    constructor(public name: string) { }
    greet(name: string) {
        return "Hello, " + this.name + " (from TypeScript!)";
    }
};