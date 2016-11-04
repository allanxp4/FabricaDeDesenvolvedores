var apagarAluno = function (id) {
    alert("ARO");
    $.get("/Aluno/Apagar/" + id)
        .done(function (data) {
            $('#aluno-' + id).remove();
            toastr.success("Apagado com sucesso");
             })
        .fail(function (error) {
            alert("deu bosta");
            console.log(error);
        })
}