class TypeScriptGreeter {
    constructor(public greeting: string) { }
    greet(name: string) {
        return this.greeting + ", " + name + " (from TypeScript)";
    }
};