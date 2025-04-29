var Tree = (function () {
    var Tree = function (value) {
        this.value = value;
        this.parent = null;
        this.children = [];
    };

    Tree.prototype.createChild = function (value) {
        var child = new Tree(value);
        child.parent = this;
        this.children.push(child);
        return child;
    };

    return Tree;
})();
