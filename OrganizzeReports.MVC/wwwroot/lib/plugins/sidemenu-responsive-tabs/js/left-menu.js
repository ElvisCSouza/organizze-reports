(function($) {
	"use strict";
	
	//Active Class
	$(".app-sidebar a").each(function() {
		var pageUrl = window.location.href.split(/[?#]/)[0];
		if (this.href == pageUrl) {
			$(this).addClass("active");
			$(this).parent().addClass("active"); // add active to li of the current link
			$(this).parent().addClass("resp-tab-content-active"); // add active to li of the current link
			$(this).parent().parent().parent().prev().addClass("active"); // add active class to an anchor
			$(this).parent().parent().parent().prev().click(); // click the item to make it drop
		}
	});
	
	$(".submenu-list li a").each(function() {
		var pageUrl = window.location.href.split(/[?#]/)[0];
		if (this.href == pageUrl) {
			$(this).addClass("active");
			$(this).parent().parent().parent().parent().parent().addClass("active"); // add active to li of the current link
			$(this).parent().parent().parent().parent().parent().addClass("resp-tab-content-active"); // add active to li of the current link
			$(this).parent().parent().parent().prev().addClass("active"); // add active class to an anchor
			$(this).parent().parent().parent().prev().click(); // click the item to make it drop
		}
	});
	
	$(document).ready(function(){		
			
		if ($('.element-yoha.active').hasClass('active'))
        $('li.element-yoha').addClass('active');
	
		if ($('.pages-yoha.active').hasClass('active'))
        $('li.pages-yoha').addClass('active');
	
		if ($('.dashboard-yoha.active').hasClass('active'))
        $('li.dashboard-yoha').addClass('active');
	
		if ($('.widget-yoha.active').hasClass('active'))
        $('li.widget-yoha').addClass('active');
		
		if ($('.components-yoha.active').hasClass('active'))
        $('li.components-yoha').addClass('active');
	
		if ($('.icons-yoha.active').hasClass('active'))
        $('li.icons-yoha').addClass('active');
	
		if ($('.forms-yoha.active').hasClass('active'))
        $('li.forms-yoha').addClass('active');
	
		if ($('.charts-yoha.active').hasClass('active'))
        $('li.charts-yoha').addClass('active');
	
		if ($('.ecommerce-yoha.active').hasClass('active'))
        $('li.ecommerce-yoha').addClass('active');
		
		if ($('.custom-yoha.active').hasClass('active'))
        $('li.custom-yoha').addClass('active');
		
		if ($('.advanced-yoha.active').hasClass('active'))
        $('li.advanced-yoha').addClass('active');
	
	});
	
	
	// VerticalTab
	$('#sidemenu-Tab').easyResponsiveTabs({
		type: 'vertical',
		width: 'auto', 
		fit: true, 
		closed: 'accordion',
		tabidentify: 'hor_1',
		activate: function(event) {
			var $tab = $(this);
			var $info = $('#nested-tabInfo2');
			var $name = $('span', $info);
			$name.text($tab.text());
			$info.show();
		}
	});
	
	const ps = new PerfectScrollbar('.first-sidemenu', {
	  useBothWheelAxes:true,
	  suppressScrollX:true,
	});
	const ps1 = new PerfectScrollbar('.second-sidemenu', {
	  useBothWheelAxes:true,
	  suppressScrollX:true,
	});
	
})(jQuery);