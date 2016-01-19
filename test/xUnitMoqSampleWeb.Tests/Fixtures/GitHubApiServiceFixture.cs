﻿using System;

using XUnitMoqSampleWeb.Services;

namespace XUnitMoqSampleWeb.Tests.Fixtures
{
    /// <summary>
    /// This represents the fixture entity for the <see cref="GitHubApiService"/> class.
    /// </summary>
    public class GitHubApiServiceFixture : IDisposable
    {
        private bool _disposed;

        /// <summary>
        /// Initializes a new instance of the <see cref="GitHubApiServiceFixture"/> class.
        /// </summary>
        public GitHubApiServiceFixture()
        {
            this.GitHubApiService = new GitHubApiService();
        }

        /// <summary>
        /// Gets the <see cref="IGitHubApiService"/> instance.
        /// </summary>
        public IGitHubApiService GitHubApiService { get; }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (this._disposed)
            {
                return;
            }

            this.GitHubApiService.Dispose();

            this._disposed = true;
        }
    }
}