$(function(){
    $('.galeria .contenedor-imagen').on('click', function(){
        $('#modal').modal;
        var laRutaDeLaImagen = ($(this).find('img').attr('src'));
        $('#imagen-modal').attr('src', laRutaDeLaImagen);
    });

    $('#modal').on('click', function(){
        $('#modal').modal('hide');
    });
})