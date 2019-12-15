window.AventiusJsFunctions = {    
    getElementProperties: function (element) {
        var elementBoundingClientRect = element.getBoundingClientRect();
        
        return {
            BoundingClientRect: {
                Bottom: elementBoundingClientRect.bottom,
                Height: elementBoundingClientRect.height,
                Left: elementBoundingClientRect.left,
                Right: elementBoundingClientRect.right,
                Top: elementBoundingClientRect.top,
                Width: elementBoundingClientRect.width,
                X: elementBoundingClientRect.x,
                Y: elementBoundingClientRect.y
            },
            ClientHeight: element.clientHeight,
            ClientLeft: element.clientLeft,
            ClientTop: element.clientTop,
            ClientWidth: element.clientWidth
        };
    }
};