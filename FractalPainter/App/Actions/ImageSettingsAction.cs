﻿using FractalPainting.Infrastructure.Common;
using FractalPainting.Infrastructure.UiActions;

namespace FractalPainting.App.Actions
{
    public class ImageSettingsAction : IUiAction
    {
        private readonly IImageHolder imageHolder;
        private readonly ImageSettings settings;

        public ImageSettingsAction(IImageHolder imageHolder, ImageSettings settings)
        {
            this.imageHolder = imageHolder;
            this.settings = settings;
        }

        public string Category => "Настройки";
        public string Name => "Изображение...";
        public string Description => "Размеры изображения";

        public void Perform()
        {
            SettingsForm.For(settings).ShowDialog();
            imageHolder.RecreateImage(settings);
        }
    }
}