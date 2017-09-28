
var elementsStyles = {
    'bootstrapGreenRedStyle' : {'whenSuccess' : 'alert alert-success',
                                'whenFailed' : 'alert alert-danger'}
};

elementsStyles.get

var answerContainers = {
    'apply-form' : {'style' : elementsStyles['bootstrapGreenRedStyle'],
                    'id' : 'answerContainer_unique44567'},
    'contact-form' : {'style' : elementsStyles['bootstrapGreenRedStyle'],
                      'id' : 'answerContainer_unique44568'}
};

answerContainers.getStyleForAnswer = function(elementId,style){
    return answerContainers[elementId]['style'][style];
}

answerContainers.getContainerId = function(elementId){
    return answerContainers[elementId]['id'];
}

/* ************************************************************ */

function FormDecorator(formId, destination) {

    this.formId = formId;
    this.destination = destination;
    var answerContainer;


    function getFormData() {
        var values = $('#' + formId).serialize();
        return values;
    }

    function successAction(data) {
        callbackAction(answerContainers.getStyleForAnswer(formId,'whenSuccess'), data.message);
    }

    function failAction(data) {
        callbackAction(answerContainers.getStyleForAnswer(formId,'whenFailed'), data.message);
    }

    function clearInputs(){
        $('#' + formId).find(':input').each(function () {
            $(this).val('');
        });
    }
    function appendAnswerContainer(containerId) {
        answerContainer = $("<div>", {
            id: containerId
        });
        $('#' + formId).append(answerContainer);
    }

    function callbackAction(divClass, message) {
        var containerId = answerContainers.getContainerId(formId);
        if (!$('#' + formId).find('#' + containerId).length) {
            appendAnswerContainer(containerId);
        }
        $(answerContainer).append(''+message)
            .addClass(divClass);
        clearInputs();
    }

    return {
        getFormData: getFormData,
        successAction: successAction,
        failAction : failAction,
        destination: destination
    };
}

/* ************************************************************ */

function SubmitForm(form, event) {
    $.ajax({
        type: 'POST',
        url: form.destination,
        data: form.getFormData(),
        dataType: 'json',
        encode: true
    })
        .done(function (data) {
            if (data.result === true) {
                form.successAction(data);
            } else {
                form.failAction(data);
            }
        })
         .fail(function (data) {
             form.failAction(data);
         });

    event.preventDefault();
}