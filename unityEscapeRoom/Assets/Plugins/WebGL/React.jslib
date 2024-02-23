mergeInto(LibraryManager.library, {
  StartGame: function (userName) {
    window.dispatchReactUnityEvent("StartGame", UTF8ToString(userName));
  },
});