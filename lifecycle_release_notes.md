# FlexiMvvm.Lifecycle Package Release Notes

## v.0.13.1 (preview)

### Bug fixing

- NavigationViewProvider.TryGetXXX methods can return false value even when view is alive.

## v.0.13 (preview)

### Existing functionality changes

- NavigationViewProvider.GetXXX methods are deprecated. Don't use them anymore. They can cause the app crash when trying to get a view that was garbage collected. Instead, use the new set of NavigationViewProvider.TryGetXXX methods.

## v.0.12 (preview)

### New functionality

- Added support for AndroidX. Set the target Android API to 10.0 (Android 10 - API 29) to use AndroidX libraries instead of Android Support ones. The target Android API prior to 10.0 will continue to use Android Support libraries.

### Existing functionality changes

- FlexiMvvm-specific activities and fragments for Android, as well as view controllers for iOS, were renamed by adding 'Flexi' prefix at the beginning of the existing name. For example, 'Fragment' now is 'FlexiFragment'.
