using BlazorMovie.Enums;
using Microsoft.AspNetCore.Components;

namespace BlazorMovie.Components.UIComponents.SearchComponents
{
    public partial class MainSearchComponent
    {
    #region CATEGORY MANAGEMENT
            #region CATEGORY CHANGED
            private void OnCategoryChanged(ChangeEventArgs e)
            {
                var stringValue = e.Value?.ToString() ?? string.Empty;
                searchModel.Category = Enum.TryParse<SearchCategory>(stringValue, out var parsedCategory) ? parsedCategory : SearchCategory.None;

                showSearchBox = searchModel.Category == SearchCategory.MovieByTitle
                             || searchModel.Category == SearchCategory.PersonByName;

                if (!showSearchBox && searchModel.Category != SearchCategory.None) NavigateToCategory(searchModel.Category);

                StateHasChanged();
            }
            #endregion

            #region HANDLE CATEGORY SELECTED
            private void HandleCategorySelected(SearchCategory selectedCategory)
            {
                searchModel.Category = selectedCategory;
                category = selectedCategory;
                showSearchBox = selectedCategory == SearchCategory.MovieByTitle
                              || selectedCategory == SearchCategory.PersonByName;

                if (!showSearchBox && searchModel.Category != SearchCategory.None) NavigateToCategory(searchModel.Category);

                StateHasChanged(); // Update UI
            }
        #endregion

        #endregion

    #region SEARCH HELPERS
        #region VALIDATE SEARCH
        private async Task<bool> ValidateSearchTerm()
        {
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                errorMessage = "Please enter a search term.";
                StateHasChanged();
                await Task.Delay(1500);
                errorMessage = string.Empty;
                StateHasChanged();
                return false;
            }
            return true;
        }
        #endregion

        #region CLEAR SEARCH
        private void HandleClearSearch()
        {
            // Reset the searchQuery to an empty string
            searchQuery = string.Empty;

            // Hide the input group
            showSearchBox = false;

            // Reset the dropdown component to its default value
            dropdownComponent?.ResetDropdown();

            // Preserve the displayed search results
            Console.WriteLine("Search cleared. Input and dropdown reset, but results remain displayed.");
            StateHasChanged(); // Update UI
        }
        #endregion
        #endregion

    #region NAVIGATION
        #region NAVIGATE TO CATEGORY PAGE
        private void NavigateToCategory(SearchCategory category)
            {
                // Null or empty category check
                if (category == SearchCategory.None)
                {
                    Console.WriteLine("Invalid category provided for navigation.");
                    return; // Exit the method if category is null or empty
                }

                // Map category to route
                var route = category switch
                {
                    SearchCategory.PopularMovies => "/",
                    SearchCategory.TopRated => " / top_rated",
                    SearchCategory.Upcoming => " / upcoming",
                    SearchCategory.NowPlaying => " / now_playing",
                    SearchCategory.SearchResults => " / search_result",
                    //fallback
                    _ => "/"
                };

                _navManager.NavigateTo(route);

            }
            #endregion
        #endregion

    #region MODAL HANDLING
            #region CLOSE PERSON MODAL
            private void ClosePersonModal()
            {
                // Called by PersonSearchResultsComponent button
                IsPersonModalOpen = false;
                SearchPersonResults = null;
            }
            #endregion

            #region MODAL CLOSE VIA "MORE DETAILS" BUTTON
            private void HandleMoreDetailsRequested(int personId)
            {
                // Called by PersonCardComponent button
                ClosePersonModal();
                _navManager.NavigateTo($"/person/{personId}");
            }
            #endregion
    #endregion
    }
}
