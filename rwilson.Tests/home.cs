using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace rwilson.Tests
{

    public class home
    {
        private Dictionary<string, string> data;
        private IWebDriver driver;
        private int timeout = 15;

        [FindsBy(How = How.CssSelector, Using = "a[href='/resources/sudden-cardiac-arrest/']")]
        [CacheLookup]
        private IWebElement aboutSuddenCardiacArrest;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement aboutUs;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(4) ul.submenu li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement aboutZoll1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(4) ul li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement aboutZoll2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(10) a")]
        [CacheLookup]
        private IWebElement accessories1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(1) ul li:nth-of-type(10) a")]
        [CacheLookup]
        private IWebElement accessories2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(2) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement aedPlus1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(1) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(6) a")]
        [CacheLookup]
        private IWebElement aedPlus2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(3) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement aedPlus3;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(4) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(8) a")]
        [CacheLookup]
        private IWebElement aedPlus4;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(5) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(8) a")]
        [CacheLookup]
        private IWebElement aedPlus5;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(6) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement aedPlus6;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(2) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement aedPlusFullyAutomatic;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(2) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement aedPro1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(1) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement aedPro2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(3) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement aedPro3;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(4) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(9) a")]
        [CacheLookup]
        private IWebElement aedPro4;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(5) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(9) a")]
        [CacheLookup]
        private IWebElement aedPro5;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(6) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement aedPro6;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement aeds1;

        [FindsBy(How = How.CssSelector, Using = "a[href='/medical-markets/hospitals/aeds/']")]
        [CacheLookup]
        private IWebElement aeds2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(1) ul li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement aeds3;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(6) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement aev1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(1) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(7) a")]
        [CacheLookup]
        private IWebElement aev2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(6) a")]
        [CacheLookup]
        private IWebElement alternateCare1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(2) ul li:nth-of-type(6) a")]
        [CacheLookup]
        private IWebElement alternateCare2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(4) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement aspirators1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(5) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement aspirators2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement automatedCpr1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(1) ul li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement automatedCpr2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(4) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement autopulse1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(1) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement autopulse2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(2) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(9) a")]
        [CacheLookup]
        private IWebElement autopulse3;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(4) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(10) a")]
        [CacheLookup]
        private IWebElement autopulse4;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(5) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(10) a")]
        [CacheLookup]
        private IWebElement autopulse5;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(4) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(1) ul.quaternary-menu li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement autopulseForEms;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(4) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(1) ul.quaternary-menu li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement autopulseForHospital;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(1) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(6) a")]
        [CacheLookup]
        private IWebElement batteries1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(10) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement batteries2;

        [FindsBy(How = How.CssSelector, Using = "a.slide.slick-slide.slick-current.slick-active")]
        [CacheLookup]
        private IWebElement bePreparedForScaWith;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm section.carousel div.slides.slick-initialized.slick-slider div.slick-list.draggable div.slick-track a:nth-of-type(2)")]
        [CacheLookup]
        private IWebElement becauseItsNotJustAbout1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm section.carousel div.slides.slick-initialized.slick-slider div.slick-list.draggable div.slick-track a:nth-of-type(6)")]
        [CacheLookup]
        private IWebElement becauseItsNotJustAbout2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(3) ul.submenu li:nth-of-type(4) ul.tertiary-menu.js-quaternary-expander li a")]
        [CacheLookup]
        private IWebElement buyAccessoriesOnline;

        [FindsBy(How = How.CssSelector, Using = "a[href='/medical-technology/cardioversion/']")]
        [CacheLookup]
        private IWebElement cardioversion;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm div:nth-of-type(3) header.site-header.js-enabled div:nth-of-type(1) ul.js-top-menu li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement careers1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(4) ul.submenu li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement careers2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(4) ul li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement careers3;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(4) ul.submenu li:nth-of-type(2) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement careersAtZoll;

        [FindsBy(How = How.CssSelector, Using = "a[href='/medical-products/temperature-management-systems/catheter-family/']")]
        [CacheLookup]
        private IWebElement catheterFamily;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(4) ul.submenu li:nth-of-type(5) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement companyOverview;

        [FindsBy(How = How.CssSelector, Using = "a[href='/about-zoll/compliance/']")]
        [CacheLookup]
        private IWebElement compliancetermsAndConditions;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(4) ul.submenu li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement contactUs1;

        [FindsBy(How = How.CssSelector, Using = "a[href='http://www.zoll.com/contact/information-request/']")]
        [CacheLookup]
        private IWebElement contactUs2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(4) ul li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement contactUs3;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(4) ul.submenu li:nth-of-type(4) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement cpr;

        [FindsBy(How = How.CssSelector, Using = "a[href='/medical-technology/cpr/cpr-dashboard/']")]
        [CacheLookup]
        private IWebElement cprDashboard;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(4) ul.submenu li:nth-of-type(4) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(1) ul.quaternary-menu li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement cprOverview;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(3) ul.submenu li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement customerService1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(3) ul.submenu li:nth-of-type(1) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement customerService2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(3) ul li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement customerService3;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement data1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(1) ul li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement data2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm div:nth-of-type(3) header.site-header.js-enabled div:nth-of-type(2) nav.secondary-nav ul li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement dataManagement1;

        [FindsBy(How = How.CssSelector, Using = "a[href='/medical-technology/data-management-documentation/']")]
        [CacheLookup]
        private IWebElement dataManagement2;

        [FindsBy(How = How.CssSelector, Using = "a[href='https://www.zolldata.com/Support/Customer-Help/']")]
        [CacheLookup]
        private IWebElement dataManagementKnowledgeBase;

        [FindsBy(How = How.CssSelector, Using = "a[href='/medical-technology/defibrillation/']")]
        [CacheLookup]
        private IWebElement defibrillation;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement defibsmonitors1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(1) ul li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement defibsmonitors2;

        [FindsBy(How = How.CssSelector, Using = "a[href='http://www.zolldata.com']")]
        [CacheLookup]
        private IWebElement deliveringIntegratedSolutionsForEvolving;

        [FindsBy(How = How.CssSelector, Using = "a[href='/contact/office-directions/']")]
        [CacheLookup]
        private IWebElement directionsToOurOffice;

        [FindsBy(How = How.CssSelector, Using = "a[href='/about-zoll/dr-paul-zoll/']")]
        [CacheLookup]
        private IWebElement drZollBiography;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(6) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement eagleIi1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(2) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(7) a")]
        [CacheLookup]
        private IWebElement eagleIi2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(6) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement eagleIiMri1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(2) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(8) a")]
        [CacheLookup]
        private IWebElement eagleIiMri2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(3) ul.submenu li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement educationAndResources1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(3) ul li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement educationAndResources2;

        [FindsBy(How = How.CssSelector, Using = "a[href='/contact/elearning/']")]
        [CacheLookup]
        private IWebElement elearning;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(1) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement electrodes1;

        [FindsBy(How = How.CssSelector, Using = "a[href='/medical-products/defibrillator-electrodes/aeds/']")]
        [CacheLookup]
        private IWebElement electrodes2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(10) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement electrodes3;

        [FindsBy(How = How.CssSelector, Using = "a[href='/medical-products/defibrillator-electrodes/ems/']")]
        [CacheLookup]
        private IWebElement electrodes4;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(2) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(13) a")]
        [CacheLookup]
        private IWebElement electrodesAndInternalPaddles;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(3) ul.submenu li:nth-of-type(1) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement emergencySupport1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(3) ul.submenu li:nth-of-type(2) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement emergencySupport2;

        [FindsBy(How = How.CssSelector, Using = "a[href='/contact/careers-at-zoll/employee-benefits/']")]
        [CacheLookup]
        private IWebElement employeeBenefits;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement emsAndFire1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(2) ul li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement emsAndFire2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(6) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement emv1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(1) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(8) a")]
        [CacheLookup]
        private IWebElement emv2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(4) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement emv3;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(5) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement emv4;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(9) a")]
        [CacheLookup]
        private IWebElement fluidResuscitation1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(1) ul li:nth-of-type(9) a")]
        [CacheLookup]
        private IWebElement fluidResuscitation2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(3) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement fullyAutomaticAedPlus;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm div:nth-of-type(3) header.site-header.js-enabled div:nth-of-type(1) div:nth-of-type(1) button.button")]
        [CacheLookup]
        private IWebElement go;

        [FindsBy(How = How.CssSelector, Using = "a[href='/contact/grant-information/']")]
        [CacheLookup]
        private IWebElement grantInformation;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement homelandSecurity1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(2) ul li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement homelandSecurity2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement hospital1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(2) ul li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement hospital2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(5) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(6) a")]
        [CacheLookup]
        private IWebElement hospitalSoftwareSolutions;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(7) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement hospitalWearableDefibrillator1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(2) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(10) a")]
        [CacheLookup]
        private IWebElement hospitalWearableDefibrillator2;

        [FindsBy(How = How.CssSelector, Using = "a[href='/contact/elearning/videos/']")]
        [CacheLookup]
        private IWebElement instructionalVideos;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(8) a")]
        [CacheLookup]
        private IWebElement iprTherapy1;

        [FindsBy(How = How.CssSelector, Using = "a[href='/medical-technology/ipr-therapy/']")]
        [CacheLookup]
        private IWebElement iprTherapy2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(1) ul li:nth-of-type(8) a")]
        [CacheLookup]
        private IWebElement iprTherapy3;

        [FindsBy(How = How.Id, Using = "LangSelect")]
        [CacheLookup]
        private IWebElement language;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm main div.wrapper div.intro-and-news article:nth-of-type(1) h2 a.button.primary")]
        [CacheLookup]
        private IWebElement learnMore;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(7) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement lifevest1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(2) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(11) a")]
        [CacheLookup]
        private IWebElement lifevest2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm div:nth-of-type(3) header.site-header.js-enabled div:nth-of-type(2) nav.secondary-nav ul li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement lifevestWearableDefibrillator;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm section.carousel div.slides.slick-initialized.slick-slider div.slick-list.draggable div.slick-track a:nth-of-type(1)")]
        [CacheLookup]
        private IWebElement lifevestWearableDefibrillatorScdProtection1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm section.carousel div.slides.slick-initialized.slick-slider div.slick-list.draggable div.slick-track a:nth-of-type(5)")]
        [CacheLookup]
        private IWebElement lifevestWearableDefibrillatorScdProtection2;

        [FindsBy(How = How.CssSelector, Using = "a[href='https://www.linkedin.com/company/13727']")]
        [CacheLookup]
        private IWebElement linkedin;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(1) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(13) a")]
        [CacheLookup]
        private IWebElement mSeries;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(2) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(14) a")]
        [CacheLookup]
        private IWebElement mSeriesAndMSeriesCct;

        [FindsBy(How = How.CssSelector, Using = "a[href='/about-zoll/management-team/']")]
        [CacheLookup]
        private IWebElement managementTeam;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement markets;

        [FindsBy(How = How.CssSelector, Using = "a[href='/about-zoll/corporate-milestones/']")]
        [CacheLookup]
        private IWebElement milestonesInHistory;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement military1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(2) ul li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement military2;

        [FindsBy(How = How.CssSelector, Using = "a[href='/about-zoll/corporate-mission/']")]
        [CacheLookup]
        private IWebElement mission;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm div:nth-of-type(4) section.reveal-callouts div.callouts figure:nth-of-type(1) figcaption div.details a")]
        [CacheLookup]
        private IWebElement moreInformation1;

        [FindsBy(How = How.CssSelector, Using = "a[href='http://info.zoll.com/hperfquiz16w']")]
        [CacheLookup]
        private IWebElement moreInformation2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm div:nth-of-type(4) section.reveal-callouts div.callouts figure:nth-of-type(3) figcaption div.details a")]
        [CacheLookup]
        private IWebElement moreInformation3;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(4) ul.submenu li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement newsAndEvents1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(4) ul li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement newsAndEvents2;

        [FindsBy(How = How.CssSelector, Using = "a[href='/news-releases/2016/']")]
        [CacheLookup]
        private IWebElement newsReleases;

        [FindsBy(How = How.CssSelector, Using = "a[href='/news/newsroom/']")]
        [CacheLookup]
        private IWebElement newsRoom;

        [FindsBy(How = How.CssSelector, Using = "button.slick-next.slick-arrow")]
        [CacheLookup]
        private IWebElement next;

        [FindsBy(How = How.CssSelector, Using = "a[href='/medical-technology/pacing/']")]
        [CacheLookup]
        private IWebElement pacing;

        private readonly string pageLoadedText = "A treatment option for the prevention of sudden cardiac death that offers patients protection and peace of mind during their changing cardiac condition";

        private readonly string pageUrl = "/";

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(2) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement plustrac1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(3) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement plustrac2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(9) ul.tertiary-menu.js-quaternary-expander li a")]
        [CacheLookup]
        private IWebElement powerInfuser1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(4) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(11) a")]
        [CacheLookup]
        private IWebElement powerInfuser2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(5) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(11) a")]
        [CacheLookup]
        private IWebElement powerInfuser3;

        [FindsBy(How = How.CssSelector, Using = "button.slick-prev.slick-arrow")]
        [CacheLookup]
        private IWebElement previous;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm div:nth-of-type(3) header.site-header.js-enabled div:nth-of-type(1) ul.js-top-menu li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement productManuals1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(1) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(7) a")]
        [CacheLookup]
        private IWebElement productManuals2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(2) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(6) a")]
        [CacheLookup]
        private IWebElement productManuals3;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(3) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement productManuals4;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(4) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement productManuals5;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(3) ul.submenu li:nth-of-type(3) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement productManuals6;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement products;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(1) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement propaqM1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(4) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement propaqM2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(5) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement propaqM3;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(1) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement propaqMd1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(4) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement propaqMd2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(5) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement propaqMd3;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement publicSafety1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(2) ul li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement publicSafety2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(1) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement rSeries1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(2) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement rSeries2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(4) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(6) a")]
        [CacheLookup]
        private IWebElement rSeries3;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(5) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(6) a")]
        [CacheLookup]
        private IWebElement rSeries4;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(6) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement rSeries5;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm main div.wrapper div.intro-and-news article:nth-of-type(2) p.action a.button.primary")]
        [CacheLookup]
        private IWebElement readAllNews;

        [FindsBy(How = How.CssSelector, Using = "a[href='/medical-technology/cpr/real-cpr-help/']")]
        [CacheLookup]
        private IWebElement realCprHelp;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(5) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement rescuenet12lead1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(1) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(9) a")]
        [CacheLookup]
        private IWebElement rescuenet12lead2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(5) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(2) ul.quaternary-menu li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement rescuenet12leadForEms;

        [FindsBy(How = How.CssSelector, Using = "a[href='/medical-products/data-management/rescuenet-12-lead/hospital/']")]
        [CacheLookup]
        private IWebElement rescuenet12leadForHospital;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(5) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement rescuenetCasereview1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(1) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(10) a")]
        [CacheLookup]
        private IWebElement rescuenetCasereview2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(5) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement rescuenetCodeReview1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(1) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(11) a")]
        [CacheLookup]
        private IWebElement rescuenetCodeReview2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(5) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement rescuenetSuite;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(8) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement resqcprSystem1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(1) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement resqcprSystem2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(8) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement resqgardItd1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(1) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement resqgardItd2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(4) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement resqgardItd3;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(5) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement resqgardItd4;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(8) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement resqpodItd1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(2) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(6) a")]
        [CacheLookup]
        private IWebElement resqpodItd2;

        [FindsBy(How = How.CssSelector, Using = "a[href='https://www.zolldata.com/Products/road-safety/overview/']")]
        [CacheLookup]
        private IWebElement roadSafety;

        [FindsBy(How = How.Id, Using = "QuickSearch")]
        [CacheLookup]
        private IWebElement searchTerms;

        [FindsBy(How = How.CssSelector, Using = "a[href='/medical-technology/cpr/see-thru-cpr/']")]
        [CacheLookup]
        private IWebElement seethruCpr;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement serviceSupport;

        [FindsBy(How = How.CssSelector, Using = "a[href='/sitemap/']")]
        [CacheLookup]
        private IWebElement siteMap;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(2) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(12) a")]
        [CacheLookup]
        private IWebElement softwareSolutions;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(3) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement stxSurfacePadSystem1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(2) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement stxSurfacePadSystem2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(3) ul.submenu li:nth-of-type(2) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement technicalServiceAndSupport;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(3) ul.submenu li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement technicalSupport1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(3) ul li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement technicalSupport2;

        [FindsBy(How = How.CssSelector, Using = "a[href='/contact/technical-training/']")]
        [CacheLookup]
        private IWebElement technicalTraining;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement temperatureManagement1;

        [FindsBy(How = How.CssSelector, Using = "a[href='/medical-technology/temperature-management/']")]
        [CacheLookup]
        private IWebElement temperatureManagement2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(1) ul li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement temperatureManagement3;

        [FindsBy(How = How.CssSelector, Using = "a[href='/about-zoll/terms-of-use/']")]
        [CacheLookup]
        private IWebElement termsOfUse;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(3) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement thermogardXp1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(2) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement thermogardXp2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(4) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(7) a")]
        [CacheLookup]
        private IWebElement thermogardXp3;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(5) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(7) a")]
        [CacheLookup]
        private IWebElement thermogardXp4;

        [FindsBy(How = How.CssSelector, Using = "a[href='/news/events/']")]
        [CacheLookup]
        private IWebElement tradeshowCalendar;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm div:nth-of-type(3) header.site-header.js-enabled div:nth-of-type(1) div:nth-of-type(2) button.button")]
        [CacheLookup]
        private IWebElement update;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(6) a")]
        [CacheLookup]
        private IWebElement ventilators1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(1) ul li:nth-of-type(6) a")]
        [CacheLookup]
        private IWebElement ventilators2;

        [FindsBy(How = How.CssSelector, Using = "a[href='/medical-products/ventilators/']")]
        [CacheLookup]
        private IWebElement ventilatorsOverview;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(4) ul.submenu li:nth-of-type(4) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(8) a")]
        [CacheLookup]
        private IWebElement wearableDefibrillator;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(7) a")]
        [CacheLookup]
        private IWebElement wearableDefibrillators1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(1) ul li:nth-of-type(7) a")]
        [CacheLookup]
        private IWebElement wearableDefibrillators2;

        [FindsBy(How = How.CssSelector, Using = "a[href='/contact/worldwide-locations/']")]
        [CacheLookup]
        private IWebElement worldwideLocations;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(1) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement xSeries1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(1) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement xSeries2;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(2) ul.submenu li:nth-of-type(2) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement xSeries3;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(1) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(2) ul.quaternary-menu li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement xSeriesForEms;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(1) ul.submenu li:nth-of-type(1) ul.tertiary-menu.js-quaternary-expander li:nth-of-type(2) ul.quaternary-menu li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement xSeriesForHospital;

        [FindsBy(How = How.CssSelector, Using = "a[href='https://www.youtube.com/zollmedical']")]
        [CacheLookup]
        private IWebElement youtube;

        [FindsBy(How = How.CssSelector, Using = "a[href='/zoll-news/']")]
        [CacheLookup]
        private IWebElement zollInTheNews;

        [FindsBy(How = How.CssSelector, Using = "a[href='http://www.zollonline.com']")]
        [CacheLookup]
        private IWebElement zollOnline;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(4) ul.submenu li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement zollTechnologies1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(4) ul li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement zollTechnologies2;

        [FindsBy(How = How.CssSelector, Using = "a[href='/news-releases/2016/11/09/aha-resuscitation-solutions-presentations/']")]
        [CacheLookup]
        private IWebElement zollTechnologyForImprovingCpr;

        [FindsBy(How = How.CssSelector, Using = "a[href='/news-releases/2016/11/08/medica-resuscitation-solutions/']")]
        [CacheLookup]
        private IWebElement zollToShowcaseExpandedPortfolio;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm nav:nth-of-type(1) ul li:nth-of-type(3) ul.submenu li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement zollWebStore1;

        [FindsBy(How = How.CssSelector, Using = "#aspnetForm footer.site-footer section:nth-of-type(1) div.wrapper ul li:nth-of-type(3) ul li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement zollWebStore2;

        public home()
            : this(default(IWebDriver), new Dictionary<string, string>(), 15)
        {
        }

        public home(IWebDriver driver)
            : this(driver, new Dictionary<string, string>(), 15)
        {
        }

        public home(IWebDriver driver, Dictionary<string, string> data)
            : this(driver, data, 15)
        {
        }

        public home(IWebDriver driver, Dictionary<string, string> data, int timeout)
        {
            this.driver = driver;
            this.data = data;
            this.timeout = timeout;
        }

        /// <summary>
        /// Click on About Sudden Cardiac Arrest Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAboutSuddenCardiacArrestLink()
        {
            aboutSuddenCardiacArrest.Click();
            return this;
        }

        /// <summary>
        /// Click on About Us Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAboutUsLink()
        {
            aboutUs.Click();
            return this;
        }

        /// <summary>
        /// Click on About Zoll Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAboutZoll1Link()
        {
            aboutZoll1.Click();
            return this;
        }

        /// <summary>
        /// Click on About Zoll Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAboutZoll2Link()
        {
            aboutZoll2.Click();
            return this;
        }

        /// <summary>
        /// Click on Accessories Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAccessories1Link()
        {
            accessories1.Click();
            return this;
        }

        /// <summary>
        /// Click on Accessories Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAccessories2Link()
        {
            accessories2.Click();
            return this;
        }

        /// <summary>
        /// Click on Aed Plus Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAedPlus1Link()
        {
            aedPlus1.Click();
            return this;
        }

        /// <summary>
        /// Click on Aed Plus Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAedPlus2Link()
        {
            aedPlus2.Click();
            return this;
        }

        /// <summary>
        /// Click on Aed Plus Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAedPlus3Link()
        {
            aedPlus3.Click();
            return this;
        }

        /// <summary>
        /// Click on Aed Plus Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAedPlus4Link()
        {
            aedPlus4.Click();
            return this;
        }

        /// <summary>
        /// Click on Aed Plus Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAedPlus5Link()
        {
            aedPlus5.Click();
            return this;
        }

        /// <summary>
        /// Click on Aed Plus Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAedPlus6Link()
        {
            aedPlus6.Click();
            return this;
        }

        /// <summary>
        /// Click on Aed Plus Fully Automatic Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAedPlusFullyAutomaticLink()
        {
            aedPlusFullyAutomatic.Click();
            return this;
        }

        /// <summary>
        /// Click on Aed Pro Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAedPro1Link()
        {
            aedPro1.Click();
            return this;
        }

        /// <summary>
        /// Click on Aed Pro Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAedPro2Link()
        {
            aedPro2.Click();
            return this;
        }

        /// <summary>
        /// Click on Aed Pro Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAedPro3Link()
        {
            aedPro3.Click();
            return this;
        }

        /// <summary>
        /// Click on Aed Pro Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAedPro4Link()
        {
            aedPro4.Click();
            return this;
        }

        /// <summary>
        /// Click on Aed Pro Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAedPro5Link()
        {
            aedPro5.Click();
            return this;
        }

        /// <summary>
        /// Click on Aed Pro Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAedPro6Link()
        {
            aedPro6.Click();
            return this;
        }

        /// <summary>
        /// Click on Aeds Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAeds1Link()
        {
            aeds1.Click();
            return this;
        }

        /// <summary>
        /// Click on Aeds Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAeds2Link()
        {
            aeds2.Click();
            return this;
        }

        /// <summary>
        /// Click on Aeds Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAeds3Link()
        {
            aeds3.Click();
            return this;
        }

        /// <summary>
        /// Click on Aev Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAev1Link()
        {
            aev1.Click();
            return this;
        }

        /// <summary>
        /// Click on Aev Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAev2Link()
        {
            aev2.Click();
            return this;
        }

        /// <summary>
        /// Click on Alternate Care Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAlternateCare1Link()
        {
            alternateCare1.Click();
            return this;
        }

        /// <summary>
        /// Click on Alternate Care Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAlternateCare2Link()
        {
            alternateCare2.Click();
            return this;
        }

        /// <summary>
        /// Click on Aspirators Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAspirators1Link()
        {
            aspirators1.Click();
            return this;
        }

        /// <summary>
        /// Click on Aspirators Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAspirators2Link()
        {
            aspirators2.Click();
            return this;
        }

        /// <summary>
        /// Click on Automated Cpr Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAutomatedCpr1Link()
        {
            automatedCpr1.Click();
            return this;
        }

        /// <summary>
        /// Click on Automated Cpr Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAutomatedCpr2Link()
        {
            automatedCpr2.Click();
            return this;
        }

        /// <summary>
        /// Click on Autopulse Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAutopulse1Link()
        {
            autopulse1.Click();
            return this;
        }

        /// <summary>
        /// Click on Autopulse Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAutopulse2Link()
        {
            autopulse2.Click();
            return this;
        }

        /// <summary>
        /// Click on Autopulse Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAutopulse3Link()
        {
            autopulse3.Click();
            return this;
        }

        /// <summary>
        /// Click on Autopulse Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAutopulse4Link()
        {
            autopulse4.Click();
            return this;
        }

        /// <summary>
        /// Click on Autopulse Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAutopulse5Link()
        {
            autopulse5.Click();
            return this;
        }

        /// <summary>
        /// Click on Autopulse For Ems Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAutopulseForEmsLink()
        {
            autopulseForEms.Click();
            return this;
        }

        /// <summary>
        /// Click on Autopulse For Hospital Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickAutopulseForHospitalLink()
        {
            autopulseForHospital.Click();
            return this;
        }

        /// <summary>
        /// Click on Batteries Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickBatteries1Link()
        {
            batteries1.Click();
            return this;
        }

        /// <summary>
        /// Click on Batteries Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickBatteries2Link()
        {
            batteries2.Click();
            return this;
        }

        /// <summary>
        /// Click on Be Prepared For Sca With The Aed Plus Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickBePreparedForScaWithLink()
        {
            bePreparedForScaWith.Click();
            return this;
        }

        /// <summary>
        /// Click on Because Its Not Just About A Shock Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickBecauseItsNotJustAbout1Link()
        {
            becauseItsNotJustAbout1.Click();
            return this;
        }

        /// <summary>
        /// Click on Because Its Not Just About A Shock Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickBecauseItsNotJustAbout2Link()
        {
            becauseItsNotJustAbout2.Click();
            return this;
        }

        /// <summary>
        /// Click on Buy Accessories Online Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickBuyAccessoriesOnlineLink()
        {
            buyAccessoriesOnline.Click();
            return this;
        }

        /// <summary>
        /// Click on Cardioversion Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickCardioversionLink()
        {
            cardioversion.Click();
            return this;
        }

        /// <summary>
        /// Click on Careers Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickCareers1Link()
        {
            careers1.Click();
            return this;
        }

        /// <summary>
        /// Click on Careers Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickCareers2Link()
        {
            careers2.Click();
            return this;
        }

        /// <summary>
        /// Click on Careers Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickCareers3Link()
        {
            careers3.Click();
            return this;
        }

        /// <summary>
        /// Click on Careers At Zoll Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickCareersAtZollLink()
        {
            careersAtZoll.Click();
            return this;
        }

        /// <summary>
        /// Click on Catheter Family Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickCatheterFamilyLink()
        {
            catheterFamily.Click();
            return this;
        }

        /// <summary>
        /// Click on Company Overview Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickCompanyOverviewLink()
        {
            companyOverview.Click();
            return this;
        }

        /// <summary>
        /// Click on Complianceterms And Conditions Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickCompliancetermsAndConditionsLink()
        {
            compliancetermsAndConditions.Click();
            return this;
        }

        /// <summary>
        /// Click on Contact Us Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickContactUs1Link()
        {
            contactUs1.Click();
            return this;
        }

        /// <summary>
        /// Click on Contact Us Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickContactUs2Link()
        {
            contactUs2.Click();
            return this;
        }

        /// <summary>
        /// Click on Contact Us Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickContactUs3Link()
        {
            contactUs3.Click();
            return this;
        }

        /// <summary>
        /// Click on Cpr Dashboard Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickCprDashboardLink()
        {
            cprDashboard.Click();
            return this;
        }

        /// <summary>
        /// Click on Cpr Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickCprLink()
        {
            cpr.Click();
            return this;
        }

        /// <summary>
        /// Click on Cpr Overview Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickCprOverviewLink()
        {
            cprOverview.Click();
            return this;
        }

        /// <summary>
        /// Click on Customer Service Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickCustomerService1Link()
        {
            customerService1.Click();
            return this;
        }

        /// <summary>
        /// Click on Customer Service Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickCustomerService2Link()
        {
            customerService2.Click();
            return this;
        }

        /// <summary>
        /// Click on Customer Service Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickCustomerService3Link()
        {
            customerService3.Click();
            return this;
        }

        /// <summary>
        /// Click on Data Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickData1Link()
        {
            data1.Click();
            return this;
        }

        /// <summary>
        /// Click on Data Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickData2Link()
        {
            data2.Click();
            return this;
        }

        /// <summary>
        /// Click on Data Management Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickDataManagement1Link()
        {
            dataManagement1.Click();
            return this;
        }

        /// <summary>
        /// Click on Data Management Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickDataManagement2Link()
        {
            dataManagement2.Click();
            return this;
        }

        /// <summary>
        /// Click on Data Management Knowledge Base Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickDataManagementKnowledgeBaseLink()
        {
            dataManagementKnowledgeBase.Click();
            return this;
        }

        /// <summary>
        /// Click on Defibrillation Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickDefibrillationLink()
        {
            defibrillation.Click();
            return this;
        }

        /// <summary>
        /// Click on Defibsmonitors Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickDefibsmonitors1Link()
        {
            defibsmonitors1.Click();
            return this;
        }

        /// <summary>
        /// Click on Defibsmonitors Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickDefibsmonitors2Link()
        {
            defibsmonitors2.Click();
            return this;
        }

        /// <summary>
        /// Click on Delivering Integrated Solutions For Evolving Fireems Environments Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickDeliveringIntegratedSolutionsForEvolvingLink()
        {
            deliveringIntegratedSolutionsForEvolving.Click();
            return this;
        }

        /// <summary>
        /// Click on Directions To Our Office Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickDirectionsToOurOfficeLink()
        {
            directionsToOurOffice.Click();
            return this;
        }

        /// <summary>
        /// Click on Dr. Zoll Biography Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickDrZollBiographyLink()
        {
            drZollBiography.Click();
            return this;
        }

        /// <summary>
        /// Click on Eagle Ii Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickEagleIi1Link()
        {
            eagleIi1.Click();
            return this;
        }

        /// <summary>
        /// Click on Eagle Ii Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickEagleIi2Link()
        {
            eagleIi2.Click();
            return this;
        }

        /// <summary>
        /// Click on Eagle Ii Mri Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickEagleIiMri1Link()
        {
            eagleIiMri1.Click();
            return this;
        }

        /// <summary>
        /// Click on Eagle Ii Mri Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickEagleIiMri2Link()
        {
            eagleIiMri2.Click();
            return this;
        }

        /// <summary>
        /// Click on Education And Resources Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickEducationAndResources1Link()
        {
            educationAndResources1.Click();
            return this;
        }

        /// <summary>
        /// Click on Education And Resources Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickEducationAndResources2Link()
        {
            educationAndResources2.Click();
            return this;
        }

        /// <summary>
        /// Click on Elearning Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickElearningLink()
        {
            elearning.Click();
            return this;
        }

        /// <summary>
        /// Click on Electrodes Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickElectrodes1Link()
        {
            electrodes1.Click();
            return this;
        }

        /// <summary>
        /// Click on Electrodes Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickElectrodes2Link()
        {
            electrodes2.Click();
            return this;
        }

        /// <summary>
        /// Click on Electrodes Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickElectrodes3Link()
        {
            electrodes3.Click();
            return this;
        }

        /// <summary>
        /// Click on Electrodes Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickElectrodes4Link()
        {
            electrodes4.Click();
            return this;
        }

        /// <summary>
        /// Click on Electrodes And Internal Paddles Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickElectrodesAndInternalPaddlesLink()
        {
            electrodesAndInternalPaddles.Click();
            return this;
        }

        /// <summary>
        /// Click on Emergency Support Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickEmergencySupport1Link()
        {
            emergencySupport1.Click();
            return this;
        }

        /// <summary>
        /// Click on Emergency Support Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickEmergencySupport2Link()
        {
            emergencySupport2.Click();
            return this;
        }

        /// <summary>
        /// Click on Employee Benefits Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickEmployeeBenefitsLink()
        {
            employeeBenefits.Click();
            return this;
        }

        /// <summary>
        /// Click on Ems And Fire Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickEmsAndFire1Link()
        {
            emsAndFire1.Click();
            return this;
        }

        /// <summary>
        /// Click on Ems And Fire Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickEmsAndFire2Link()
        {
            emsAndFire2.Click();
            return this;
        }

        /// <summary>
        /// Click on Emv Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickEmv1Link()
        {
            emv1.Click();
            return this;
        }

        /// <summary>
        /// Click on Emv Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickEmv2Link()
        {
            emv2.Click();
            return this;
        }

        /// <summary>
        /// Click on Emv Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickEmv3Link()
        {
            emv3.Click();
            return this;
        }

        /// <summary>
        /// Click on Emv Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickEmv4Link()
        {
            emv4.Click();
            return this;
        }

        /// <summary>
        /// Click on Fluid Resuscitation Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickFluidResuscitation1Link()
        {
            fluidResuscitation1.Click();
            return this;
        }

        /// <summary>
        /// Click on Fluid Resuscitation Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickFluidResuscitation2Link()
        {
            fluidResuscitation2.Click();
            return this;
        }

        /// <summary>
        /// Click on Fully Automatic Aed Plus Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickFullyAutomaticAedPlusLink()
        {
            fullyAutomaticAedPlus.Click();
            return this;
        }

        /// <summary>
        /// Click on Go Button.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickGoButton()
        {
            go.Click();
            return this;
        }

        /// <summary>
        /// Click on Grant Information Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickGrantInformationLink()
        {
            grantInformation.Click();
            return this;
        }

        /// <summary>
        /// Click on Homeland Security Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickHomelandSecurity1Link()
        {
            homelandSecurity1.Click();
            return this;
        }

        /// <summary>
        /// Click on Homeland Security Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickHomelandSecurity2Link()
        {
            homelandSecurity2.Click();
            return this;
        }

        /// <summary>
        /// Click on Hospital Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickHospital1Link()
        {
            hospital1.Click();
            return this;
        }

        /// <summary>
        /// Click on Hospital Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickHospital2Link()
        {
            hospital2.Click();
            return this;
        }

        /// <summary>
        /// Click on Hospital Software Solutions Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickHospitalSoftwareSolutionsLink()
        {
            hospitalSoftwareSolutions.Click();
            return this;
        }

        /// <summary>
        /// Click on Hospital Wearable Defibrillator Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickHospitalWearableDefibrillator1Link()
        {
            hospitalWearableDefibrillator1.Click();
            return this;
        }

        /// <summary>
        /// Click on Hospital Wearable Defibrillator Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickHospitalWearableDefibrillator2Link()
        {
            hospitalWearableDefibrillator2.Click();
            return this;
        }

        /// <summary>
        /// Click on Instructional Videos Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickInstructionalVideosLink()
        {
            instructionalVideos.Click();
            return this;
        }

        /// <summary>
        /// Click on Ipr Therapy Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickIprTherapy1Link()
        {
            iprTherapy1.Click();
            return this;
        }

        /// <summary>
        /// Click on Ipr Therapy Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickIprTherapy2Link()
        {
            iprTherapy2.Click();
            return this;
        }

        /// <summary>
        /// Click on Ipr Therapy Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickIprTherapy3Link()
        {
            iprTherapy3.Click();
            return this;
        }

        /// <summary>
        /// Click on Learn More Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickLearnMoreLink()
        {
            learnMore.Click();
            return this;
        }

        /// <summary>
        /// Click on Lifevest Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickLifevest1Link()
        {
            lifevest1.Click();
            return this;
        }

        /// <summary>
        /// Click on Lifevest Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickLifevest2Link()
        {
            lifevest2.Click();
            return this;
        }

        /// <summary>
        /// Click on Lifevest Wearable Defibrillator Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickLifevestWearableDefibrillatorLink()
        {
            lifevestWearableDefibrillator.Click();
            return this;
        }

        /// <summary>
        /// Click on Lifevest Wearable Defibrillator Scd Protection During A Patients Changing Cardiac Condition Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickLifevestWearableDefibrillatorScdProtection1Link()
        {
            lifevestWearableDefibrillatorScdProtection1.Click();
            return this;
        }

        /// <summary>
        /// Click on Lifevest Wearable Defibrillator Scd Protection During A Patients Changing Cardiac Condition Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickLifevestWearableDefibrillatorScdProtection2Link()
        {
            lifevestWearableDefibrillatorScdProtection2.Click();
            return this;
        }

        /// <summary>
        /// Click on Linkedin Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickLinkedinLink()
        {
            linkedin.Click();
            return this;
        }

        /// <summary>
        /// Click on M Series And M Series Cct Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickMSeriesAndMSeriesCctLink()
        {
            mSeriesAndMSeriesCct.Click();
            return this;
        }

        /// <summary>
        /// Click on M Series Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickMSeriesLink()
        {
            mSeries.Click();
            return this;
        }

        /// <summary>
        /// Click on Management Team Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickManagementTeamLink()
        {
            managementTeam.Click();
            return this;
        }

        /// <summary>
        /// Click on Markets Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickMarketsLink()
        {
            markets.Click();
            return this;
        }

        /// <summary>
        /// Click on Milestones In History Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickMilestonesInHistoryLink()
        {
            milestonesInHistory.Click();
            return this;
        }

        /// <summary>
        /// Click on Military Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickMilitary1Link()
        {
            military1.Click();
            return this;
        }

        /// <summary>
        /// Click on Military Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickMilitary2Link()
        {
            military2.Click();
            return this;
        }

        /// <summary>
        /// Click on Mission Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickMissionLink()
        {
            mission.Click();
            return this;
        }

        /// <summary>
        /// Click on More Information Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickMoreInformation1Link()
        {
            moreInformation1.Click();
            return this;
        }

        /// <summary>
        /// Click on More Information Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickMoreInformation2Link()
        {
            moreInformation2.Click();
            return this;
        }

        /// <summary>
        /// Click on More Information Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickMoreInformation3Link()
        {
            moreInformation3.Click();
            return this;
        }

        /// <summary>
        /// Click on News And Events Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickNewsAndEvents1Link()
        {
            newsAndEvents1.Click();
            return this;
        }

        /// <summary>
        /// Click on News And Events Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickNewsAndEvents2Link()
        {
            newsAndEvents2.Click();
            return this;
        }

        /// <summary>
        /// Click on News Releases Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickNewsReleasesLink()
        {
            newsReleases.Click();
            return this;
        }

        /// <summary>
        /// Click on News Room Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickNewsRoomLink()
        {
            newsRoom.Click();
            return this;
        }

        /// <summary>
        /// Click on Next Button.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickNextButton()
        {
            next.Click();
            return this;
        }

        /// <summary>
        /// Click on Pacing Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickPacingLink()
        {
            pacing.Click();
            return this;
        }

        /// <summary>
        /// Click on Plustrac Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickPlustrac1Link()
        {
            plustrac1.Click();
            return this;
        }

        /// <summary>
        /// Click on Plustrac Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickPlustrac2Link()
        {
            plustrac2.Click();
            return this;
        }

        /// <summary>
        /// Click on Power Infuser Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickPowerInfuser1Link()
        {
            powerInfuser1.Click();
            return this;
        }

        /// <summary>
        /// Click on Power Infuser Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickPowerInfuser2Link()
        {
            powerInfuser2.Click();
            return this;
        }

        /// <summary>
        /// Click on Power Infuser Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickPowerInfuser3Link()
        {
            powerInfuser3.Click();
            return this;
        }

        /// <summary>
        /// Click on Previous Button.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickPreviousButton()
        {
            previous.Click();
            return this;
        }

        /// <summary>
        /// Click on Product Manuals Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickProductManuals1Link()
        {
            productManuals1.Click();
            return this;
        }

        /// <summary>
        /// Click on Product Manuals Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickProductManuals2Link()
        {
            productManuals2.Click();
            return this;
        }

        /// <summary>
        /// Click on Product Manuals Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickProductManuals3Link()
        {
            productManuals3.Click();
            return this;
        }

        /// <summary>
        /// Click on Product Manuals Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickProductManuals4Link()
        {
            productManuals4.Click();
            return this;
        }

        /// <summary>
        /// Click on Product Manuals Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickProductManuals5Link()
        {
            productManuals5.Click();
            return this;
        }

        /// <summary>
        /// Click on Product Manuals Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickProductManuals6Link()
        {
            productManuals6.Click();
            return this;
        }

        /// <summary>
        /// Click on Products Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickProductsLink()
        {
            products.Click();
            return this;
        }

        /// <summary>
        /// Click on Propaq M Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickPropaqM1Link()
        {
            propaqM1.Click();
            return this;
        }

        /// <summary>
        /// Click on Propaq M Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickPropaqM2Link()
        {
            propaqM2.Click();
            return this;
        }

        /// <summary>
        /// Click on Propaq M Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickPropaqM3Link()
        {
            propaqM3.Click();
            return this;
        }

        /// <summary>
        /// Click on Propaq Md Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickPropaqMd1Link()
        {
            propaqMd1.Click();
            return this;
        }

        /// <summary>
        /// Click on Propaq Md Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickPropaqMd2Link()
        {
            propaqMd2.Click();
            return this;
        }

        /// <summary>
        /// Click on Propaq Md Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickPropaqMd3Link()
        {
            propaqMd3.Click();
            return this;
        }

        /// <summary>
        /// Click on Public Safety Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickPublicSafety1Link()
        {
            publicSafety1.Click();
            return this;
        }

        /// <summary>
        /// Click on Public Safety Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickPublicSafety2Link()
        {
            publicSafety2.Click();
            return this;
        }

        /// <summary>
        /// Click on R Series Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickRSeries1Link()
        {
            rSeries1.Click();
            return this;
        }

        /// <summary>
        /// Click on R Series Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickRSeries2Link()
        {
            rSeries2.Click();
            return this;
        }

        /// <summary>
        /// Click on R Series Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickRSeries3Link()
        {
            rSeries3.Click();
            return this;
        }

        /// <summary>
        /// Click on R Series Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickRSeries4Link()
        {
            rSeries4.Click();
            return this;
        }

        /// <summary>
        /// Click on R Series Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickRSeries5Link()
        {
            rSeries5.Click();
            return this;
        }

        /// <summary>
        /// Click on Read All News Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickReadAllNewsLink()
        {
            readAllNews.Click();
            return this;
        }

        /// <summary>
        /// Click on Real Cpr Help Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickRealCprHelpLink()
        {
            realCprHelp.Click();
            return this;
        }

        /// <summary>
        /// Click on Rescuenet 12lead Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickRescuenet12lead1Link()
        {
            rescuenet12lead1.Click();
            return this;
        }

        /// <summary>
        /// Click on Rescuenet 12lead Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickRescuenet12lead2Link()
        {
            rescuenet12lead2.Click();
            return this;
        }

        /// <summary>
        /// Click on Rescuenet 12lead For Ems Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickRescuenet12leadForEmsLink()
        {
            rescuenet12leadForEms.Click();
            return this;
        }

        /// <summary>
        /// Click on Rescuenet 12lead For Hospital Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickRescuenet12leadForHospitalLink()
        {
            rescuenet12leadForHospital.Click();
            return this;
        }

        /// <summary>
        /// Click on Rescuenet Casereview Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickRescuenetCasereview1Link()
        {
            rescuenetCasereview1.Click();
            return this;
        }

        /// <summary>
        /// Click on Rescuenet Casereview Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickRescuenetCasereview2Link()
        {
            rescuenetCasereview2.Click();
            return this;
        }

        /// <summary>
        /// Click on Rescuenet Code Review Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickRescuenetCodeReview1Link()
        {
            rescuenetCodeReview1.Click();
            return this;
        }

        /// <summary>
        /// Click on Rescuenet Code Review Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickRescuenetCodeReview2Link()
        {
            rescuenetCodeReview2.Click();
            return this;
        }

        /// <summary>
        /// Click on Rescuenet Suite Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickRescuenetSuiteLink()
        {
            rescuenetSuite.Click();
            return this;
        }

        /// <summary>
        /// Click on Resqcpr System Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickResqcprSystem1Link()
        {
            resqcprSystem1.Click();
            return this;
        }

        /// <summary>
        /// Click on Resqcpr System Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickResqcprSystem2Link()
        {
            resqcprSystem2.Click();
            return this;
        }

        /// <summary>
        /// Click on Resqgard Itd Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickResqgardItd1Link()
        {
            resqgardItd1.Click();
            return this;
        }

        /// <summary>
        /// Click on Resqgard Itd Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickResqgardItd2Link()
        {
            resqgardItd2.Click();
            return this;
        }

        /// <summary>
        /// Click on Resqgard Itd Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickResqgardItd3Link()
        {
            resqgardItd3.Click();
            return this;
        }

        /// <summary>
        /// Click on Resqgard Itd Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickResqgardItd4Link()
        {
            resqgardItd4.Click();
            return this;
        }

        /// <summary>
        /// Click on Resqpod Itd Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickResqpodItd1Link()
        {
            resqpodItd1.Click();
            return this;
        }

        /// <summary>
        /// Click on Resqpod Itd Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickResqpodItd2Link()
        {
            resqpodItd2.Click();
            return this;
        }

        /// <summary>
        /// Click on Road Safety Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickRoadSafetyLink()
        {
            roadSafety.Click();
            return this;
        }

        /// <summary>
        /// Click on Seethru Cpr Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickSeethruCprLink()
        {
            seethruCpr.Click();
            return this;
        }

        /// <summary>
        /// Click on Service Support Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickServiceSupportLink()
        {
            serviceSupport.Click();
            return this;
        }

        /// <summary>
        /// Click on Site Map Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickSiteMapLink()
        {
            siteMap.Click();
            return this;
        }

        /// <summary>
        /// Click on Software Solutions Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickSoftwareSolutionsLink()
        {
            softwareSolutions.Click();
            return this;
        }

        /// <summary>
        /// Click on Stx Surface Pad System Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickStxSurfacePadSystem1Link()
        {
            stxSurfacePadSystem1.Click();
            return this;
        }

        /// <summary>
        /// Click on Stx Surface Pad System Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickStxSurfacePadSystem2Link()
        {
            stxSurfacePadSystem2.Click();
            return this;
        }

        /// <summary>
        /// Click on Technical Service And Support Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickTechnicalServiceAndSupportLink()
        {
            technicalServiceAndSupport.Click();
            return this;
        }

        /// <summary>
        /// Click on Technical Support Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickTechnicalSupport1Link()
        {
            technicalSupport1.Click();
            return this;
        }

        /// <summary>
        /// Click on Technical Support Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickTechnicalSupport2Link()
        {
            technicalSupport2.Click();
            return this;
        }

        /// <summary>
        /// Click on Technical Training Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickTechnicalTrainingLink()
        {
            technicalTraining.Click();
            return this;
        }

        /// <summary>
        /// Click on Temperature Management Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickTemperatureManagement1Link()
        {
            temperatureManagement1.Click();
            return this;
        }

        /// <summary>
        /// Click on Temperature Management Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickTemperatureManagement2Link()
        {
            temperatureManagement2.Click();
            return this;
        }

        /// <summary>
        /// Click on Temperature Management Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickTemperatureManagement3Link()
        {
            temperatureManagement3.Click();
            return this;
        }

        /// <summary>
        /// Click on Terms Of Use Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickTermsOfUseLink()
        {
            termsOfUse.Click();
            return this;
        }

        /// <summary>
        /// Click on Thermogard Xp Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickThermogardXp1Link()
        {
            thermogardXp1.Click();
            return this;
        }

        /// <summary>
        /// Click on Thermogard Xp Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickThermogardXp2Link()
        {
            thermogardXp2.Click();
            return this;
        }

        /// <summary>
        /// Click on Thermogard Xp Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickThermogardXp3Link()
        {
            thermogardXp3.Click();
            return this;
        }

        /// <summary>
        /// Click on Thermogard Xp Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickThermogardXp4Link()
        {
            thermogardXp4.Click();
            return this;
        }

        /// <summary>
        /// Click on Tradeshow Calendar Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickTradeshowCalendarLink()
        {
            tradeshowCalendar.Click();
            return this;
        }

        /// <summary>
        /// Click on Update Button.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickUpdateButton()
        {
            update.Click();
            return this;
        }

        /// <summary>
        /// Click on Ventilators Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickVentilators1Link()
        {
            ventilators1.Click();
            return this;
        }

        /// <summary>
        /// Click on Ventilators Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickVentilators2Link()
        {
            ventilators2.Click();
            return this;
        }

        /// <summary>
        /// Click on Ventilators Overview Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickVentilatorsOverviewLink()
        {
            ventilatorsOverview.Click();
            return this;
        }

        /// <summary>
        /// Click on Wearable Defibrillator Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickWearableDefibrillatorLink()
        {
            wearableDefibrillator.Click();
            return this;
        }

        /// <summary>
        /// Click on Wearable Defibrillators Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickWearableDefibrillators1Link()
        {
            wearableDefibrillators1.Click();
            return this;
        }

        /// <summary>
        /// Click on Wearable Defibrillators Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickWearableDefibrillators2Link()
        {
            wearableDefibrillators2.Click();
            return this;
        }

        /// <summary>
        /// Click on Worldwide Locations Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickWorldwideLocationsLink()
        {
            worldwideLocations.Click();
            return this;
        }

        /// <summary>
        /// Click on X Series Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickXSeries1Link()
        {
            xSeries1.Click();
            return this;
        }

        /// <summary>
        /// Click on X Series Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickXSeries2Link()
        {
            xSeries2.Click();
            return this;
        }

        /// <summary>
        /// Click on X Series Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickXSeries3Link()
        {
            xSeries3.Click();
            return this;
        }

        /// <summary>
        /// Click on X Series For Ems Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickXSeriesForEmsLink()
        {
            xSeriesForEms.Click();
            return this;
        }

        /// <summary>
        /// Click on X Series For Hospital Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickXSeriesForHospitalLink()
        {
            xSeriesForHospital.Click();
            return this;
        }

        /// <summary>
        /// Click on Youtube Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickYoutubeLink()
        {
            youtube.Click();
            return this;
        }

        /// <summary>
        /// Click on Zoll In The News Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickZollInTheNewsLink()
        {
            zollInTheNews.Click();
            return this;
        }

        /// <summary>
        /// Click on Zoll Online Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickZollOnlineLink()
        {
            zollOnline.Click();
            return this;
        }

        /// <summary>
        /// Click on Zoll Technologies Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickZollTechnologies1Link()
        {
            zollTechnologies1.Click();
            return this;
        }

        /// <summary>
        /// Click on Zoll Technologies Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickZollTechnologies2Link()
        {
            zollTechnologies2.Click();
            return this;
        }

        /// <summary>
        /// Click on Zoll Technology For Improving Cpr Quality To Be At Aha Annual Conference Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickZollTechnologyForImprovingCprLink()
        {
            zollTechnologyForImprovingCpr.Click();
            return this;
        }

        /// <summary>
        /// Click on Zoll To Showcase Expanded Portfolio Of Advanced Resuscitation And Acute Critical Care Technologies At Medica 2016 Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickZollToShowcaseExpandedPortfolioLink()
        {
            zollToShowcaseExpandedPortfolio.Click();
            return this;
        }

        /// <summary>
        /// Click on Zoll Web Store Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickZollWebStore1Link()
        {
            zollWebStore1.Click();
            return this;
        }

        /// <summary>
        /// Click on Zoll Web Store Link.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home ClickZollWebStore2Link()
        {
            zollWebStore2.Click();
            return this;
        }

        /// <summary>
        /// Fill every fields in the page.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home Fill()
        {
            SetSearchTermsSearchField();
            SetLanguageDropDownListField();
            return this;
        }

        /// <summary>
        /// Fill every fields in the page and submit it to target page.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home FillAndSubmit()
        {
            Fill();
            return Submit();
        }

        /// <summary>
        /// Set default value to Language Drop Down List field.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home SetLanguageDropDownListField()
        {
            return SetLanguageDropDownListField(data["LANGUAGE"]);
        }

        /// <summary>
        /// Set value to Language Drop Down List field.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home SetLanguageDropDownListField(string languageValue)
        {
            new SelectElement(language).SelectByText(languageValue);
            return this;
        }

        /// <summary>
        /// Set default value to Search Terms Search field.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home SetSearchTermsSearchField()
        {
            return SetSearchTermsSearchField(data["SEARCH_TERMS"]);
        }

        /// <summary>
        /// Set value to Search Terms Search field.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home SetSearchTermsSearchField(string searchTermsValue)
        {
            searchTerms.SendKeys(searchTermsValue);
            return this;
        }

        /// <summary>
        /// Submit the form to target page.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home Submit()
        {
            ClickGoButton();
            return this;
        }

        /// <summary>
        /// Unset default value from Language Drop Down List field.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home UnsetLanguageDropDownListField()
        {
            return UnsetLanguageDropDownListField(data["LANGUAGE"]);
        }

        /// <summary>
        /// Unset value from Language Drop Down List field.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home UnsetLanguageDropDownListField(string languageValue)
        {
            new SelectElement(language).DeselectByText(languageValue);
            return this;
        }

        /// <summary>
        /// Verify that the page loaded completely.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home VerifyPageLoaded()
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until<bool>((d) =>
            {
                return d.PageSource.Contains(pageLoadedText);
            });
            return this;
        }

        /// <summary>
        /// Verify that current page URL matches the expected URL.
        /// </summary>
        /// <returns>The home class instance.</returns>
        public home VerifyPageUrl()
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until<bool>((d) =>
            {
                return d.Url.Contains(pageUrl);
            });
            return this;
        }
    }
}