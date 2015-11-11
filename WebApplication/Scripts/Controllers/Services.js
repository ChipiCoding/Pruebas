App.service("WCFService", function ($http) {
    this.GetCustomers = function () {
        return $http.get("http://localhost:58511/CustomerService.svc/GetCustomers/");
    };
});
