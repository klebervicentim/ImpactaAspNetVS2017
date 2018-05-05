$(document).ready(inicializar);

var pesquisarButton = {};

function inicializar() {
    pesquisarButton = $("#pesquisarButton");
    pesquisarButton.click(obterProdutoPorCategoria);

    //var fecharPopoverButton = $("#fecharPopover");
    //fecharPopoverButton.click(fecharPopover);

    $(document).on("click", "#fecharPopover",
        function () {
            pesquisarButton.popover("destroy");

    });
    
}

function obterProdutoPorCategoria() {

    const categoriaId = $("#CategoriaId").val();

    $.ajax({

        url: "/Produtos/Categoria",
        method: "GET",
        data: { categoriaId }

    }).done(function (response) { exibirPopOver(response); })
        //.fail() - quando dá pau
        //.always() - sempre execute
        ;
}

function exibirPopOver(response) {
    pesquisarButton
        .popover("destroy")
        .popover({
            content: montarGridProdutos(response),
            html: true,
            animation: true,
            title: "Produtos desta categoria <span class='close' id='fecharPopover'> &times;></span>"
        })
        .popover("show");
}

function montarGridProdutos(produtos) {
        var html = "<table class='table table-striped'>";

        html += "<tr><th>Produto</th><th>Preço</th><th>Estoque</th></tr>";

        $(produtos).each(
            function (i) {
                html += "<tr>";
                html += "<td>" + produtos[i].Nome + "</td>";
                html += "<td>" + produtos[i].Preco.toLocaleString('pt-br', { style: 'currency', currency: 'BRL' }) + "</td>";
                html += "<td>" + produtos[i].Estoque + "</td>";
                html += "</tr>";
            }
        );

        return html + "</table>";
}



