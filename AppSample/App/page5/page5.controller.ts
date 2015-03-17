module app.page5 {
    'use strict';
    class Page5Controller {
        static $inject = ['app.services.navigation'];
        constructor(nav: app.services.INavigationService) {
            nav.setCurrentStep(5);
            var vm = this;
        }
    }

    angular.module('app.page5').controller('app.page5.Controller', Page5Controller);
}   