var tpj=jQuery;
			var revapi1050;
			tpj(document).ready(function() {
				if(tpj("#rev_slider_1050_1").revolution == undefined){
					revslider_showDoubleJqueryError("#rev_slider_1050_1");
				}else{
					revapi1050 = tpj("#rev_slider_1050_1").show().revolution({
						sliderType:"standard",
jsFileLocation:"revolution/js/",
						sliderLayout:"fullwidth",
						dottedOverlay:"none",
						delay:7000,
						navigation: {
							arrows: {
								enable: true,
								style: 'uranus',
							},
							keyboardNavigation:"on",
							keyboard_direction: "vertical",
							mouseScrollNavigation:"off",
 							mouseScrollReverse:"default",
							onHoverStop:"off",
							touch:{
								touchenabled:"on",
								swipe_threshold: 75,
								swipe_min_touches: 50,
								swipe_direction: "vertical",
								drag_block_vertical: false
							}
							,
							bullets: {
								enable:true,
								hide_onmobile:true,
								hide_under:1024,
								style:"hephaistos",
								hide_onleave:false,
								direction:"horizontal",
								h_align:"right",
								v_align:"center",
								h_offset:30,
								v_offset:0,
								space:5,
								tmp:''
							}
						},
						responsiveLevels:[1240,1024,778,480],
						visibilityLevels:[1240,1024,778,480],
						gridwidth:[1400,1240,375,375],
						gridheight:[500,500,300,300],
						lazyType:"smart",
						shadow:0,
						spinner:"spinner2",
						stopLoop:"off",
						stopAfterLoops:-1,
						stopAtSlide:-1,
						shuffle:"off",
						autoHeight:"off",
						fullScreenAutoWidth:"off",
						fullScreenAlignForce:"off",
						fullScreenOffsetContainer: "",
						fullScreenOffset: "",
						disableProgressBar:"on",
						hideThumbsOnMobile:"off",
						hideSliderAtLimit:0,
						hideCaptionAtLimit:0,
						hideAllCaptionAtLilmit:0,
						debugMode:false,
						fallbacks: {
							simplifyAll:"off",
							nextSlideOnWindowFocus:"off",
							disableFocusListener:false,
						}
					});
				}
			});