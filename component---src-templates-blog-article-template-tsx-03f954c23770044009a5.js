(self.webpackChunkchillicream_website=self.webpackChunkchillicream_website||[]).push([[457],{6219:function(e,t,n){"use strict";n.d(t,{G:function(){return i}});var r=n(7294),o=n(9925),a=n(1315),i=function(e){var t=e.data,n=t.fields,o=t.frontmatter;return r.createElement(l,null,r.createElement(c,{to:o.authorUrl},r.createElement(s,{src:o.authorImageUrl}),o.author)," ","・ ",o.date," ・ ",n.readingTime.text)},l=o.ZP.div.withConfig({displayName:"blog-article-metadata__Metadata",componentId:"sc-1ds34n3-0"})(["display:flex;flex-direction:row;align-items:center;margin:0 20px 20px;font-size:0.778em;@media only screen and (min-width:820px){margin:0 50px 20px;}"]),c=(0,o.ZP)(a.r).withConfig({displayName:"blog-article-metadata__AuthorLink",componentId:"sc-1ds34n3-1"})(["display:flex;flex:0 0 auto;flex-direction:row;align-items:center;color:var(--text-color);"]),s=o.ZP.img.withConfig({displayName:"blog-article-metadata__AuthorImage",componentId:"sc-1ds34n3-2"})(["flex:0 0 auto;margin-right:0.5em;border-radius:15px;width:30px;"])},1373:function(e,t,n){"use strict";n.d(t,{d:function(){return i}});var r=n(7294),o=n(9925),a=n(1315),i=function(e){var t=e.tags;return r.createElement(r.Fragment,null,t.length>0&&r.createElement(l,null,t.map((function(e){return r.createElement(c,{key:e},r.createElement(s,{to:"/blog/tags/"+e},e))}))))},l=o.ZP.ul.withConfig({displayName:"blog-article-tags__Tags",componentId:"sc-1tid7rp-0"})(["margin:0 20px 20px;list-style-type:none;@media only screen and (min-width:820px){margin:0 50px 20px;}"]),c=o.ZP.li.withConfig({displayName:"blog-article-tags__Tag",componentId:"sc-1tid7rp-1"})(["display:inline-block;margin:0 5px 5px 0;border-radius:var(--border-radius);padding:0;background-color:var(--brand-color);font-size:0.722em;letter-spacing:0.05em;color:var(--text-color-contrast);"]),s=(0,o.ZP)(a.r).withConfig({displayName:"blog-article-tags__TagLink",componentId:"sc-1tid7rp-2"})(["display:block;padding:5px 15px;color:var(--text-color-contrast);"])},8338:function(e,t,n){"use strict";n.r(t),n.d(t,{default:function(){return X}});var r,o=n(7294),a=n(3217),i=n(9394),l=n(9925),c=n(3914),s=n(6570),d=n(9042),u=n(6219),p=(r=function(e,t){return(r=Object.setPrototypeOf||{__proto__:[]}instanceof Array&&function(e,t){e.__proto__=t}||function(e,t){for(var n in t)Object.prototype.hasOwnProperty.call(t,n)&&(e[n]=t[n])})(e,t)},function(e,t){function n(){this.constructor=e}r(e,t),e.prototype=null===t?Object.create(t):(n.prototype=t.prototype,new n)}),f=function(e){function t(t){var n=e.call(this,t)||this;return n.name="AssertionError",n}return p(t,e),t}(Error);function h(e,t){if(!e)throw new f(t)}function m(e){var t=Object.entries(e).filter((function(e){var t=e[1];return null!=t})).map((function(e){var t=e[0],n=e[1];return encodeURIComponent(t)+"="+encodeURIComponent(String(n))}));return t.length>0?"?"+t.join("&"):""}var w=n(9931),g=n.n(w),y=function(){var e=function(t,n){return(e=Object.setPrototypeOf||{__proto__:[]}instanceof Array&&function(e,t){e.__proto__=t}||function(e,t){for(var n in t)Object.prototype.hasOwnProperty.call(t,n)&&(e[n]=t[n])})(t,n)};return function(t,n){function r(){this.constructor=t}e(t,n),t.prototype=null===n?Object.create(n):(r.prototype=n.prototype,new r)}}(),b=function(){return(b=Object.assign||function(e){for(var t,n=1,r=arguments.length;n<r;n++)for(var o in t=arguments[n])Object.prototype.hasOwnProperty.call(t,o)&&(e[o]=t[o]);return e}).apply(this,arguments)},v=function(e,t,n,r){return new(n||(n=Promise))((function(o,a){function i(e){try{c(r.next(e))}catch(t){a(t)}}function l(e){try{c(r.throw(e))}catch(t){a(t)}}function c(e){var t;e.done?o(e.value):(t=e.value,t instanceof n?t:new n((function(e){e(t)}))).then(i,l)}c((r=r.apply(e,t||[])).next())}))},x=function(e,t){var n,r,o,a,i={label:0,sent:function(){if(1&o[0])throw o[1];return o[1]},trys:[],ops:[]};return a={next:l(0),throw:l(1),return:l(2)},"function"==typeof Symbol&&(a[Symbol.iterator]=function(){return this}),a;function l(a){return function(l){return function(a){if(n)throw new TypeError("Generator is already executing.");for(;i;)try{if(n=1,r&&(o=2&a[0]?r.return:a[0]?r.throw||((o=r.return)&&o.call(r),0):r.next)&&!(o=o.call(r,a[1])).done)return o;switch(r=0,o&&(a=[2&a[0],o.value]),a[0]){case 0:case 1:o=a;break;case 4:return i.label++,{value:a[1],done:!1};case 5:i.label++,r=a[1],a=[0];continue;case 7:a=i.ops.pop(),i.trys.pop();continue;default:if(!(o=i.trys,(o=o.length>0&&o[o.length-1])||6!==a[0]&&2!==a[0])){i=0;continue}if(3===a[0]&&(!o||a[1]>o[0]&&a[1]<o[3])){i.label=a[1];break}if(6===a[0]&&i.label<o[1]){i.label=o[1],o=a;break}if(o&&i.label<o[2]){i.label=o[2],i.ops.push(a);break}o[2]&&i.ops.pop(),i.trys.pop();continue}a=t.call(e,i)}catch(l){a=[6,l],r=0}finally{n=o=0}if(5&a[0])throw a[1];return{value:a[0]?a[1]:void 0,done:!0}}([a,l])}}},k=function(e,t){var n={};for(var r in e)Object.prototype.hasOwnProperty.call(e,r)&&t.indexOf(r)<0&&(n[r]=e[r]);if(null!=e&&"function"==typeof Object.getOwnPropertySymbols){var o=0;for(r=Object.getOwnPropertySymbols(e);o<r.length;o++)t.indexOf(r[o])<0&&Object.prototype.propertyIsEnumerable.call(e,r[o])&&(n[r[o]]=e[r[o]])}return n},_=function(e){return!!e&&("object"==typeof e||"function"==typeof e)&&"function"==typeof e.then},E=function(e,t){return{left:window.outerWidth/2+(window.screenX||window.screenLeft||0)-e/2,top:window.outerHeight/2+(window.screenY||window.screenTop||0)-t/2}},C=function(e,t){return{top:(window.screen.height-t)/2,left:(window.screen.width-e)/2}};function O(e,t,n){var r=t.height,o=t.width,a=k(t,["height","width"]),i=b({height:r,width:o,location:"no",toolbar:"no",status:"no",directories:"no",menubar:"no",scrollbars:"yes",resizable:"no",centerscreen:"yes",chrome:"yes"},a),l=window.open(e,"",Object.keys(i).map((function(e){return e+"="+i[e]})).join(", "));if(n)var c=window.setInterval((function(){try{(null===l||l.closed)&&(window.clearInterval(c),n(l))}catch(e){console.error(e)}}),1e3);return l}var P=function(e){function t(){var t=null!==e&&e.apply(this,arguments)||this;return t.openShareDialog=function(e){var n=t.props,r=n.onShareWindowClose,o=n.windowHeight,a=void 0===o?400:o,i=n.windowPosition,l=void 0===i?"windowCenter":i,c=n.windowWidth,s=void 0===c?550:c;O(e,b({height:a,width:s},"windowCenter"===l?E(s,a):C(s,a)),r)},t.handleClick=function(e){return v(t,void 0,void 0,(function(){var t,n,r,o,a,i,l,c,s,d;return x(this,(function(u){switch(u.label){case 0:return t=this.props,n=t.beforeOnClick,r=t.disabled,o=t.networkLink,a=t.onClick,i=t.url,l=t.openShareDialogOnClick,c=t.opts,s=o(i,c),r?[2]:(e.preventDefault(),n?(d=n(),_(d)?[4,d]:[3,2]):[3,2]);case 1:u.sent(),u.label=2;case 2:return l&&this.openShareDialog(s),a&&a(e,s),[2]}}))}))},t}return y(t,e),t.prototype.render=function(){var e=this.props,t=(e.beforeOnClick,e.children),n=e.className,r=e.disabled,a=e.disabledStyle,i=e.forwardedRef,l=(e.networkLink,e.networkName),c=(e.onShareWindowClose,e.openShareDialogOnClick,e.opts,e.resetButtonStyle),s=e.style,d=(e.url,e.windowHeight,e.windowPosition,e.windowWidth,k(e,["beforeOnClick","children","className","disabled","disabledStyle","forwardedRef","networkLink","networkName","onShareWindowClose","openShareDialogOnClick","opts","resetButtonStyle","style","url","windowHeight","windowPosition","windowWidth"])),u=g()("react-share__ShareButton",{"react-share__ShareButton--disabled":!!r,disabled:!!r},n),p=b(b(c?{backgroundColor:"transparent",border:"none",padding:0,font:"inherit",color:"inherit",cursor:"pointer"}:{},s),r&&a);return o.createElement("button",b({},d,{"aria-label":d["aria-label"]||l,className:u,onClick:this.handleClick,ref:i,style:p}),t)},t.defaultProps={disabledStyle:{opacity:.6},openShareDialogOnClick:!0,resetButtonStyle:!0},t}(o.Component),S=function(){return(S=Object.assign||function(e){for(var t,n=1,r=arguments.length;n<r;n++)for(var o in t=arguments[n])Object.prototype.hasOwnProperty.call(t,o)&&(e[o]=t[o]);return e}).apply(this,arguments)};var I=function(e,t,n,r){function a(a,i){var l=n(a),c=S({},a);return Object.keys(l).forEach((function(e){delete c[e]})),o.createElement(P,S({},r,c,{forwardedRef:i,networkName:e,networkLink:t,opts:n(a)}))}return a.displayName="ShareButton-"+e,(0,o.forwardRef)(a)};var j=I("twitter",(function(e,t){var n=t.title,r=t.via,o=t.hashtags,a=void 0===o?[]:o,i=t.related,l=void 0===i?[]:i;return h(e,"twitter.url"),h(Array.isArray(a),"twitter.hashtags is not an array"),h(Array.isArray(l),"twitter.related is not an array"),"https://twitter.com/share"+m({url:e,text:n,via:r,hashtags:a.length>0?a.join(","):void 0,related:l.length>0?l.join(","):void 0})}),(function(e){return{hashtags:e.hashtags,title:e.title,via:e.via,related:e.related}}),{windowWidth:550,windowHeight:400});var N=I("linkedin",(function(e,t){var n=t.title,r=t.summary,o=t.source;return h(e,"linkedin.url"),"https://linkedin.com/shareArticle"+m({url:e,mini:"true",title:n,summary:r,source:o})}),(function(e){return{title:e.title,summary:e.summary,source:e.source}}),{windowWidth:750,windowHeight:600}),A=n(1871),z=n.n(A),H=n(1227),Z=n.n(H),D=function(e){var t=e.data,n=t.mdx,r=t.site,a=e.tags,i=n.frontmatter,l=r.siteMetadata.siteUrl+i.path,c=i.title;return o.createElement(W,null,o.createElement(j,{url:l,title:c,via:r.siteMetadata.author,hashtags:a},o.createElement(B,null)),o.createElement(N,{url:l,title:c},o.createElement(L,null)))},W=l.ZP.aside.withConfig({displayName:"blog-article-sharebar__ShareButtons",componentId:"sc-1yzpkav-0"})(["position:fixed;left:calc(50% - 480px);display:none;flex-direction:column;padding:150px 0 250px;width:60px;> button{flex:0 0 50px;> svg{width:30px;}}@media only screen and (min-width:992px){display:flex;}"]),B=(0,l.ZP)(Z()).withConfig({displayName:"blog-article-sharebar__TwitterIcon",componentId:"sc-1yzpkav-1"})(["fill:#1da0f2;"]),L=(0,l.ZP)(z()).withConfig({displayName:"blog-article-sharebar__LinkedinIcon",componentId:"sc-1yzpkav-2"})(["fill:#0073b0;"]),V=n(1373),M=function(e){var t,n,r=e.data,l=r.mdx,p=l,f=p.frontmatter,h=p.body,m=f.path,w=f.title,g=f.tags?f.tags.filter((function(e){return e&&e.length>0})):[],y=null===(t=f.featuredImage)||void 0===t||null===(n=t.childImageSharp)||void 0===n?void 0:n.gatsbyImageData;return o.createElement(T,null,o.createElement(D,{data:r,tags:g}),o.createElement(R,null,o.createElement(c.d,null,o.createElement(d.K3,{kind:"blog"},y&&o.createElement(a.G,{image:y,alt:w}),o.createElement(d.j1,null,w),o.createElement(u.G,{data:l}),o.createElement(V.d,{tags:g})),o.createElement(d.Jx,null,o.createElement(i.MDXRenderer,null,h))),o.createElement(s.m,{data:r,path:m,title:w})))},R=l.ZP.div.withConfig({displayName:"blog-article__ArticleWrapper",componentId:"sc-1kh97hj-0"})(["display:grid;grid-template-rows:1fr auto;padding:0;@media only screen and (min-width:820px){padding:20px 10px 0;}"]),T=l.ZP.div.withConfig({displayName:"blog-article__Container",componentId:"sc-1kh97hj-1"})(["display:flex;flex:0 0 auto;flex-direction:row;width:100%;max-width:820px;"]),U=n(5740),G=n(4795),X=function(e){var t,n=e.data;return o.createElement(G.A,null,o.createElement(U.H,{description:n.mdx.excerpt||void 0,imageUrl:null===(t=n.mdx.frontmatter.featuredImage)||void 0===t?void 0:t.childImageSharp.gatsbyImageData.src,isArticle:!0,title:n.mdx.frontmatter.title}),o.createElement(M,{data:n}))}},1871:function(e,t,n){var r=n(7294);function o(e){return r.createElement("svg",e,r.createElement("path",{d:"M416 32H31.9C14.3 32 0 46.5 0 64.3v383.4C0 465.5 14.3 480 31.9 480H416c17.6 0 32-14.5 32-32.3V64.3c0-17.8-14.4-32.3-32-32.3zM135.4 416H69V202.2h66.5V416zm-33.2-243c-21.3 0-38.5-17.3-38.5-38.5S80.9 96 102.2 96c21.2 0 38.5 17.3 38.5 38.5 0 21.3-17.2 38.5-38.5 38.5zm282.1 243h-66.4V312c0-24.8-.5-56.7-34.5-56.7-34.6 0-39.9 27-39.9 54.9V416h-66.4V202.2h63.7v29.2h.9c8.9-16.8 30.6-34.5 62.9-34.5 67.2 0 79.7 44.3 79.7 101.9V416z"}))}o.defaultProps={viewBox:"0 0 448 512"},e.exports=o,o.default=o},1227:function(e,t,n){var r=n(7294);function o(e){return r.createElement("svg",e,r.createElement("path",{d:"M400 32H48C21.5 32 0 53.5 0 80v352c0 26.5 21.5 48 48 48h352c26.5 0 48-21.5 48-48V80c0-26.5-21.5-48-48-48zm-48.9 158.8c.2 2.8.2 5.7.2 8.5 0 86.7-66 186.6-186.6 186.6-37.2 0-71.7-10.8-100.7-29.4 5.3.6 10.4.8 15.8.8 30.7 0 58.9-10.4 81.4-28-28.8-.6-53-19.5-61.3-45.5 10.1 1.5 19.2 1.5 29.6-1.2-30-6.1-52.5-32.5-52.5-64.4v-.8c8.7 4.9 18.9 7.9 29.6 8.3a65.447 65.447 0 0 1-29.2-54.6c0-12.2 3.2-23.4 8.9-33.1 32.3 39.8 80.8 65.8 135.2 68.6-9.3-44.5 24-80.6 64-80.6 18.9 0 35.9 7.9 47.9 20.7 14.8-2.8 29-8.3 41.6-15.8-4.9 15.2-15.2 28-28.8 36.1 13.2-1.4 26-5.1 37.8-10.2-8.9 13.1-20.1 24.7-32.9 34z"}))}o.defaultProps={viewBox:"0 0 448 512"},e.exports=o,o.default=o}}]);
//# sourceMappingURL=component---src-templates-blog-article-template-tsx-03f954c23770044009a5.js.map