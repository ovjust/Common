var DefaultIndex = DefaultIndex || {};

DefaultIndex = function() {
    var init = function() {
        $("#mainLayout").kendoSplitter({
            panes: [
                { collapsible: true, size: "200px" }
            ]
        });
        $("#panelbar").kendoPanelBar({
            expandMode: "mutli"
        });
        $("li[rel='append']").click(function () {
            var href = $(this).attr('value');
            window.location.href = href;
        });
    };
    return {
        init: init
    };
}();