function carregaTemplate(retorno) {
    var tabela = $("#comentarios");
    var template = $('#tmpComentario').html();
    var consolidado = Mustache.render(template, retorno);
    tabela.append(consolidado);
}