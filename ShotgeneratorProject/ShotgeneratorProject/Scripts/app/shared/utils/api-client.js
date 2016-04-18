//modernaServices.service('apiClient', ['$http', '$q', '$log', 'configManager', function ($http, $q, $log, configManager) {
//    var baseUrl = 'http://' + configManager.get('webApiHost') + '/api';

//    var onSuccess = function (action, response) {
//        $log.debug(action + ': Successfully received response from API.');
//        return response.data;
//    };

//    var onError = function (action, error) {
//        if (!error || !error.data) {
//            return $q.reject({
//                statusCode: error.status,
//                message: error.data.message
//            });
//        }

//        var errorMessage = '';
//        // Check if error is a simple string
//        if (typeof error.data === 'string') {
//            errorMessage = error.data;
//        }
//            // Check if error is a WebApi error object
//        else if (error.data.message && error.data.exceptionMessage) {
//            errorMessage = error.data.exceptionMessage;
//        }
//            // If no exceptionMessage is set, use provided message.
//        else if (error.data.message) {
//            errorMessage = error.data.message;
//        }

//        $log.error(action + ': an error occured (' + error.status + ' ' + error.statusText + '): ' + errorMessage);
//        return $q.reject({
//            statusCode: error.status,
//            message: errorMessage
//        });
//    };

//    this.getAllRoles = function () {
//        return $http.get(baseUrl + '/roles')
//			.then(function (response) { return onSuccess('getAllRoles', response); })
//			.catch(function (error) { return onError('getAllRoles', error); });
//    };

//    this.getPersonalPoints = function () {
//        return $http.get(baseUrl + '/points/personal')
//			.then(function (response) { return onSuccess('getPersonalPoints', response); })
//			.catch(function (error) { return onError('getPersonalPoints', error); });
//    };

//    this.getTopList = function () {
//        return $http.get(baseUrl + '/points/toplist')
//			.then(function (response) { return onSuccess('getTopList', response); })
//			.catch(function (error) { return onError('getTopList', error); });
//    };

//    this.getPointsOverview = function () {
//        return $http.get(baseUrl + '/points/overview')
//			.then(function (response) { return onSuccess('getPointsOverview', response); })
//			.catch(function (error) { return onError('getPointsOverview', error); });
//    };

//    this.getPointsLog = function (latestTransactionDate) {
//        var body = {
//            latestTransaction: latestTransactionDate === undefined ? null : latestTransactionDate
//        };

//        return $http.post(baseUrl + '/points/log', body)
//			.then(function (response) { return onSuccess('getPointsLog', response); })
//			.catch(function (error) { return onError('getPointsLog', error); });
//    };

//    this.redeemPoints = function (username, amount) {
//        return $http.put(baseUrl + '/points/' + username, "=" + amount, {
//            headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8' }
//        })
//		  .then(function (response) { return onSuccess('redeemPoints', response); })
//		  .catch(function (error) { return onError('redeemPoints', error); });
//    };

//    this.searchUser = function (searchQuery) {
//        return $http.post(baseUrl + '/user/search', '=' + searchQuery,
//			{ headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8' } })
//			.then(function (response) { return onSuccess('searchUser', response); })
//			.catch(function (error) { return onError('searchUser', error); });
//    };

//    this.getUser = function (username) {
//        username = username ? username : '';

//        return $http.get(baseUrl + '/user/' + username)
//			.then(function (response) { return onSuccess('getUser', response); })
//			.catch(function (error) { return onError('getUser', error); });
//    };

//    this.getShopUsers = function (shopId) {
//        return $http.get(baseUrl + '/user/shop/' + shopId)
//			.then(function (response) { return onSuccess('getShopUsers', response); })
//			.catch(function (error) { return onError('getShopUsers', error); });
//    };

//    this.createUser = function (user) {
//        return $http.post(baseUrl + '/user/', user)
//			.then(function (response) { return onSuccess('createUser', response); })
//			.catch(function (error) { return onError('createUser', error); });
//    };

//    this.updateUser = function (username, user) {
//        return $http.put(baseUrl + '/user/' + username, user)
//			.then(function (response) { return onSuccess('updateUser', response); })
//			.catch(function (error) { return onError('updateUser', error); });
//    };

//    this.updatePassword = function (username, password) {
//        return $http.put(baseUrl + '/auth/' + username, "=" + password, {
//            headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8' }
//        })
//			.then(function (response) { return onSuccess('updatePassword', response); })
//			.catch(function (error) { return onError('updatePassword', error); });
//    };

//    this.getAllShops = function () {
//        return $http.get(baseUrl + '/shops')
//			.then(function (response) { return onSuccess('getAllShops', response); })
//			.catch(function (error) { return onError('getAllShops', error); });
//    };

//    this.connectUserToShop = function (shopId, departmentId, email) {
//        var requestUrl = '{1}/shop/{2}/{3}/{4}'.assign(baseUrl, shopId, departmentId, email);
//        return $http.put(requestUrl)
//			.then(function (response) { return onSuccess('connectUserToShop', response); })
//			.catch(function (error) { return onError('connectUserToShop', error); });
//    };

//    this.deactiveUserFromShop = function (id, username) {
//        var requestUrl = '{1}/shop/{2}/{3}'.assign(baseUrl, id, username);
//        return $http.delete(requestUrl)
//			.then(function (response) { return onSuccess('deactiveUserFromShop', response); })
//			.catch(function (error) { return onError('deactiveUserFromShop', error); });
//    };

//    this.getInsurance = function (customerId, insuranceId) {
//        var requestUrl = '{1}/insurance/{2}/{3}'.assign(baseUrl, customerId, insuranceId);
//        return $http.get(requestUrl)
//			.then(function (response) { return onSuccess('getInsurance', response); })
//			.catch(function (error) { return onError('getInsurance', error); });
//    };

//    this.getInsuranceFields = function (objectGroupId, shopId, username) {
//        return $http.post(baseUrl + '/insurance/fields', { objectGroupId: objectGroupId, shopId: shopId, userName: username })
//			.then(function (response) { return onSuccess('getInsuranceFields', response); })
//			.catch(function (error) { return onError('getInsuranceFields', error); });
//    };

//    this.getClaim = function (claimId, insuranceId) {

//        var requestUrl = baseUrl + '/claim/' + claimId;
//        if (insuranceId) {
//            requestUrl += '/' + insuranceId;
//        }
//        return $http.get(requestUrl)
//			.then(function (response) { return onSuccess('getClaim', response); })
//			.catch(function (error) { return onError('getClaim', error); });
//    };

//    this.getClaimFields = function (insuranceId, shopId) {
//        return $http.get(baseUrl + '/claim/fields/' + insuranceId + '/' + shopId)
//			.then(function (response) { return onSuccess('getClaimFields', response); })
//			.catch(function (error) { return onError('getClaimFields', error); });
//    };

//    this.registerClaim = function (claim) {
//        return $http.post(baseUrl + '/claim', claim)
//            .then(function (response) { return onSuccess('createClaim', response); })
//            .catch(function (error) { return onError('createClaim', error); });
//    };

//    this.registerInsurance = function (insurance) {
//        return $http.post(baseUrl + '/insurance', insurance)
//			.then(function (response) { return onSuccess('registerInsurance', response); })
//			.catch(function (error) { return onError('registerInsurance', error); });
//    };

//    this.verifyInsurance = function (insuranceNo) {
//        return $http.post(baseUrl + '/insurance/verify', '=' + insuranceNo,
//        { headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8' } })
//			.then(function (response) { return onSuccess('verifyInsurance', response); })
//			.catch(function (error) { return onError('verifyInsurance', error); });
//    };

//    this.cancelInsurance = function (insuranceNo) {
//        return $http.post(baseUrl + '/insurance/cancel/' + insuranceNo)
//			.then(function (response) { return onSuccess('cancelInsurance', response); })
//			.catch(function (error) { return onError('cancelInsurance', error); });
//    };

//    this.getAllTests = function () {
//        return $http.get(baseUrl + '/tests')
//            .then(function (response) { return onSuccess('getAllTests', response); })
//            .catch(function (error) { return onError('getAllTests', error); });
//    };

//    this.getTest = function (eLearningTestId) {
//        return $http.get(baseUrl + '/tests/' + eLearningTestId)
//            .then(function (response) { return onSuccess('getTest', response); })
//            .catch(function (error) { return onError('getTest', error); });
//    };

//    this.takeTest = function (testId, testAnswers) {
//        return $http.put(baseUrl + '/tests/' + testId, testAnswers)
//			.then(function (response) { return onSuccess('takeTest', response); })
//			.catch(function (error) { return onError('takeTest', error); });
//    };

//    this.getCustomer = function (id) {
//        return $http.get(baseUrl + '/customer/' + id)
//        .then(function (response) { return onSuccess('getCustomer', response); })
//        .catch(function (error) { return onError('getCustomer', error); });
//    }

//    this.updateCustomer = function (customer) {
//        return $http.put(baseUrl + '/customer/', customer)
//			.then(function (response) { return onSuccess('updateCustomer', response); })
//			.catch(function (error) { return onError('updateCustomer', error); });
//    }

//    this.searchCustomer = function (searchQuery) {
//        return $http.post(baseUrl + '/customer/search', '=' + searchQuery,
//			{ headers: { 'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8' } })
//			.then(function (response) { return onSuccess('searchCustomer', response); })
//			.catch(function (error) { return onError('searchCustomer', error); });
//    };

//    this.updateSerialNumber = function (insuranceNo, customerNo, serialNo) {
//        return $http.put(baseUrl + '/customer/updateserial/' + insuranceNo + "/" + customerNo + "/" + serialNo)
//			.then(function (response) { return onSuccess('updateSerialNumber', response); })
//			.catch(function (error) { return onError('updateSerialNumber', error); });
//    }

//    this.getProducts = function () {
//        return $http.get(baseUrl + '/products')
//			.then(function (response) { return onSuccess('getProducts', response); })
//			.catch(function (error) { return onError('getProducts', error); });
//    }

//    this.getAllProducts = function () {
//        return $http.get(baseUrl + '/products/getAll')
//			.then(function (response) { return onSuccess('getAllProducts', response); })
//			.catch(function (error) { return onError('getAllProducts', error); });
//    }

//    this.initializePremiumTender = function (blockId) {
//        return $http.get('/Premium/Init/' + blockId)	// Target MVC controller (not WebApi)
//            .then(function (response) { return onSuccess('initializePremiumTender', response); })
//            .catch(function (error) { return onError('initializePremiumTender', error); });
//    };

//    this.getPremiumFields = function (defaultObjGroupId, defaultAction, objectDefinition) {
//        return $http.post(baseUrl + '/premium/fields', { defaultObjectGroupId: defaultObjGroupId, defaultAction: defaultAction, objectDefinition: objectDefinition })
//            .then(function (response) { return onSuccess('getPremiumFields', response); })
//            .catch(function (error) { return onError('getPremiumFields', error); });
//    };

//    this.getInvoiceDetails = function (insuranceId, referenceNo) {
//        return $http.get(baseUrl + '/invoice/' + insuranceId + '/' + referenceNo)
//            .then(function (response) { return onSuccess('getInvoiceDetails', response); })
//            .catch(function (error) { return onError('getInvoiceDetails', error); });
//    };

//    this.registerBoxInsurance = function (insuranceNo) {
//        return $http.post(baseUrl + '/insurance/registerbox/' + insuranceNo)
//            .then(function (response) {
//                return onSuccess('registerBoxInsurance', response);
//            })
//            .catch(function (error) {
//                return onError('registerBoxInsurance', error);
//            });
//    };

//    this.verifyActivationCode = function (activationCode) {
//        return $http.post(baseUrl + '/insurance/verify/' + activationCode)
//            .then(function(response) {
//                return onSuccess("verifyActivationCode", response);
//            }).catch(function(error) {
//                return onError("verifyActivationCode", error);
//            });
//    };

//    this.getAllBrands = function () {
//        return $http.get(baseUrl + '/brands/')
//            .then(function (response) {
//                return onSuccess("getAllBrands", response);
//            }).catch(function (error) {
//                return onError("getAllBrands", error);
//            });
//    };

//    this.activateUnit = function(customerNo, activationCode, boughtPrice, boughtDate, brandId, model, serialNo) {
//        return $http.post(baseUrl + '/insurance/activate/' + customerNo + '/' + activationCode + '/' + boughtPrice + '/' + boughtDate + '/' + brandId + '/' + model + '/' + serialNo)
//            .then(function(response) {
//                return onSuccess("activateUnit", response);
//            }).catch(function(error) {
//                return onError("activateUnit", error);
//            });
//    };
//}]);