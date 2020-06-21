using img2ascii.Event;
using img2ascii.Model;
using img2ascii.View;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace img2ascii.Presenter
{
    class SelectPresenter
    {
        private readonly SelectView View;

        public SelectPresenter(SelectView view)
        {
            View = view;
            view.Click += OnClick;
        }

        /// <summary>
        /// Method that is called when the view is clicked.
        /// </summary>
        /// <param name="sender">The event caller.</param>
        /// <param name="e">The event arguments.</param>
        private void OnClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png",
                Multiselect = false,
                Title = "Image File Select"
            };

            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            if (!dialog.CheckFileExists)
            {
                MessageBox.Show("The specified file does not exist.", "Invalid");
                return;
            }
            if (!IsValidImage(dialog.FileName))
            {
                MessageBox.Show("The specified file is not a valid image.", "Invalid");
                return;
            }

            Image image = Image.FromFile(dialog.FileName);
            InputMetadata metadata = new InputMetadata(image);

            EventAggregator.Instance.Publish(new ImageSelectEvent(metadata));
        }

        /// <summary>
        /// Method to determine if the specified file is a valid image.
        /// </summary>
        /// <param name="filepath">The path to the image file.</param>
        /// <returns>True if it is a valid image, and false otherwise.</returns>
        private bool IsValidImage(String filepath)
        {
            try
            {
                using (Image image = Image.FromFile(filepath))
                {
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
