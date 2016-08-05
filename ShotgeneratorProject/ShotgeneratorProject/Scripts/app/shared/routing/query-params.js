//modernaFactories.factory('queryParams', ['$window', '$stateParams', function ($window, $stateParams) {
//	var queryParams = $window.location.search.substring(1).split('&');

//	// Note that 'regular' query parameters take precedence over $stateParams, i.e. if a query paramter
//	// with the same key exists in both, the one in $stateParams will be overwritten.
//	var mappedParams = $stateParams;

//	queryParams.each(function (q) {
//		if (q.length > 0) {
//			var parts = q.split('=');
//			mappedParams[parts[0]] = decodeURIComponent(parts[1].replace(/\+/g, '%20'));
//		}
//	});

//	return mappedParams;
//}]);