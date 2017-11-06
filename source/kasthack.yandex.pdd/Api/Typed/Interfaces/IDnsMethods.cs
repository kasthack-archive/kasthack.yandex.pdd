﻿using System.Threading.Tasks;
using kasthack.yandex.pdd.Entities;

namespace kasthack.yandex.pdd.Methods
{
    /// <summary>
    /// DNS methods
    /// </summary>
    public interface IDnsMethods
    {
        /// <summary>
        /// Add a DNS record. <see href="https://tech.yandex.ru/pdd/doc/reference/dns-add-docpage/">Yandex doc</see>
        /// </summary>
        /// <param name="record">Record data</param>
        /// <returns>Add status</returns>
        Task<DnsRecordResponse> Add(AddDnsRecord record);
        /// <summary>
        /// Delete a DNS record. <see href="https://tech.yandex.ru/pdd/doc/reference/dns-del-docpage/">Yandex doc</see>
        /// </summary>
        /// <param name="recordId">Record ID</param>
        /// <returns>Deleteion status</returns>
        Task<DeleteDnsRespone> Delete(long recordId);
        /// <summary>
        /// Update a DNS record. <see href="https://tech.yandex.ru/pdd/doc/reference/dns-edit-docpage/">Yandex doc</see>
        /// </summary>
        /// <param name="record">Record data</param>
        /// <returns>Update status</returns>
        Task<DnsRecordsResponse> Edit(DnsRecord record);
        /// <summary>
        /// Show dns records. <see href="https://tech.yandex.ru/pdd/doc/reference/dns-list-docpage/">Yandex doc</see>
        /// </summary>
        /// <returns>DNS records</returns>
        Task<DnsRecordsResponse> List();
    }
}