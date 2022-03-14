export function ShowCookie() {
    return document.cookie
}
export function AddCookie(key,value, year, month,day){
document.cookie = key+"="+value+"; expires=" + new Date(year,month,day).toUTCString() +"; SameSite=lax"

};
export function  GetUserAgent(){
    return navigator.userAgent;
};
export function GetLanguage(){
    return window.navigator.userLanguage || window.navigator.language;

};
export function GetHost(){
    return location.host;
}