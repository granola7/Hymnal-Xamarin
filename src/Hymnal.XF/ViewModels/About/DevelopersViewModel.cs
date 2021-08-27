using System.Collections.Generic;
using Hymnal.XF.Constants;
using Hymnal.XF.Services;
using Microsoft.AppCenter.Analytics;
using Prism.Navigation;

namespace Hymnal.XF.ViewModels
{
    public sealed class DevelopersViewModel : BaseViewModel
    {
        private readonly IPreferencesService preferencesService;

        public DevelopersViewModel(
            INavigationService navigationService,
            IPreferencesService preferencesService
            ) : base(navigationService)
        {
            this.preferencesService = preferencesService;
        }

        public override void OnAppearing()
        {
            base.OnAppearing();

            Analytics.TrackEvent(TrackingConstants.TrackEv.Navigation, new Dictionary<string, string>
            {
                { TrackingConstants.TrackEv.NavigationReferenceScheme.PageName, nameof(DevelopersViewModel) },
                { TrackingConstants.TrackEv.NavigationReferenceScheme.CultureInfo, InfoConstants.CurrentCultureInfo.Name },
                { TrackingConstants.TrackEv.NavigationReferenceScheme.HymnalVersion, preferencesService.ConfiguratedHymnalLanguage.Id }
            });
        }
    }
}
